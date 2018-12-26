using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using CryptoLibrary;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;

namespace CryptoClient
{
    public partial class CryptoClientForm : MaterialSkin.Controls.MaterialForm
    {
        private ICryptoLibrary algoritham;

        private static readonly UTF8Encoding utf8 = new UTF8Encoding();
        private Dictionary<string, byte[]> specs;
        string folderPathForEncrypting = string.Empty;
        string folderPathForDecrypting = string.Empty;
        FileSystemWatcher watcher;
        FileSystemWatcher destWatcher;

        string defaultSrcPath = "Encrypt";
        string defaultDstPath = "Decrypt";

        public CryptoClientForm()
        {
            InitializeComponent();
        }

        private void CryptoClientForm_Load(object sender, EventArgs e)
        {

            this.tbSrcPath.Text = ".\\" + this.defaultSrcPath;
            this.tbDstPath.Text = ".\\" + this.defaultDstPath;
            this.defaultSrcPath = AppDomain.CurrentDomain.BaseDirectory.ToString() + this.defaultSrcPath;
            this.defaultDstPath = AppDomain.CurrentDomain.BaseDirectory.ToString() + this.defaultDstPath;

            string[] srcDicFiles = Directory.GetFiles(this.defaultSrcPath);

            foreach (string f in srcDicFiles)
            {
                this.lbFilesToEncrypt.Items.Add(f);
            }

            string[] dstDicFiles = Directory.GetFiles(this.defaultDstPath);

            foreach (string f in dstDicFiles)
            {
                this.lbEncryptedFiles.Items.Add(f);
            }

            this.CreateNewFileWatcher();


            ICryptoLibrary[] algorithams = new ICryptoLibrary[4];
            algorithams[0] = new SimpleSubstitution();
            algorithams[1] = new XXTEA();
            algorithams[2] = new SHA2();
            algorithams[3] = new Knapsack();

            specs = new Dictionary<string, byte[]>();

            // add algoritams in drop down
            ToolStripMenuItem menu = new ToolStripMenuItem("Algorithams");
            ToolStripMenuItem item;

            for (int i = 0; i < algorithams.Length; i++)
            {
                item = new ToolStripMenuItem(algorithams[i].ToString());
                item.Tag = algorithams[i];
                menu.DropDownItems.Add(item);
                if (i == 0)
                    this.algoritham = algorithams[i];
            }

            menu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnClickedItem);
            this.msOptions.Items.Add(menu);

            this.Init();
            tbN.KeyPress += this.tbKey_KeyPress;
            tbM.KeyPress += this.tbKey_KeyPress;
            tbIM.KeyPress += this.tbKey_KeyPress;
            lbHint.Visible = false;
        }

        private void Init()
        {
            #region Simple Substitution init

            char[] test = new char[26];
            for (int i = 65; i < (65 + 26); i++)
            {
                test[i - 65] = (char)i;
            }

            this.tbData.Text = new string(test);
            // encoding problem fixed like this :)
            this.tbKey.Text = new string(Encoding.Default.GetChars(this.algoritham.GenerateRandomKey()));
            this.gbAlgorithm.Text = this.algoritham.ToString();

            #endregion

            gbKnapSackProp.Enabled = false;
        }

        private void OnClickedItem(object sender, ToolStripItemClickedEventArgs e)
        {
            if (algoritham.GetType() != ((ICryptoLibrary)e.ClickedItem.Tag).GetType())
            {
                this.algoritham = (ICryptoLibrary)e.ClickedItem.Tag;
                byte[] key;
                if (this.algoritham.GetType() != typeof(SHA2))
                {
                    key = this.algoritham.GenerateRandomKey();
                    btnRandomGenerateKey.Enabled = true;
                    btnSetKey.Enabled = true;
                    btnDecode.Enabled = true;
                    btnDecryptAll.Enabled = true;
                    btnDecryptSeleced.Enabled = true;
                    btnDecodeFromFile.Enabled = true;
                }
                else
                {
                    key = ((SHA2)this.algoritham).GetKey();
                    btnRandomGenerateKey.Enabled = false;
                    btnSetKey.Enabled = false;
                    btnDecode.Enabled = false;
                    btnDecryptAll.Enabled = false;
                    btnDecryptSeleced.Enabled = false;
                    btnDecodeFromFile.Enabled = false;
                }

                if (this.algoritham.GetType() != typeof(Knapsack))
                {
                    gbKnapSackProp.Enabled = false;
                    //tbKey.Enabled = true;
                    tbKey.KeyPress -= this.tbKey_KeyPress;
                    lbHint.Visible = false;
                }
                else
                {
                    // set up for knapsack
                    gbKnapSackProp.Enabled = true;
                    //tbKey.Enabled = false;
                    tbKey.KeyPress += this.tbKey_KeyPress;

                    tbN.Text = ((Knapsack)this.algoritham).n.ToString();
                    tbM.Text = ((Knapsack)this.algoritham).m.ToString();
                    tbIM.Text = ((Knapsack)this.algoritham).mInverse.ToString();
                    lbHint.Visible = true;
                }

                // encoding problem fixed like this :)
                if (this.algoritham.GetType() != typeof(Knapsack))
                    this.tbKey.Text = new string(Encoding.Default.GetChars(key));
                else
                {
                    //uint[] temp = new uint[key.Length / 4];
                    //string tempKeyStr = string.Empty;

                    //for (
                    //    int i = 0; i < key.Length; i += 4)
                    //{
                    //    temp[i / 4] = BitConverter.ToUInt32(key, i);
                    //    tempKeyStr += " " + BitConverter.ToUInt32(key, i);
                    //}

                    //this.tbKey.Text = tempKeyStr;
                    this.tbKey.Text = string.Join(", ", key.Select(x => x.ToString()).ToArray());
                }
                this.gbAlgorithm.Text = this.algoritham.ToString();
            }
        }

        private void btnSetKey_Click(object sender, EventArgs e)
        {
            if (algoritham.GetType() != typeof(Knapsack))
                this.algoritham.SetKey(Encoding.UTF8.GetBytes(this.tbKey.Text));
            else
                this.checkAndSetForKnapsack();
        }

        private void btnRandomGenerateKey_Click(object sender, EventArgs e)
        {
            if (this.algoritham.GetType() == typeof(Knapsack))
                this.checkAndSetForKnapsack();

            byte[] rKey = this.algoritham.GenerateRandomKey();

            if (this.algoritham.GetType() == typeof(Knapsack))
            {
                //uint[] temp = new uint[rKey.Length / 4];
                //string tempKeyStr = string.Empty;

                //for (
                //    int i = 0; i < rKey.Length; i += 4)
                //{
                //    temp[i / 4] = BitConverter.ToUInt32(rKey, i);
                //    tempKeyStr += " " + BitConverter.ToUInt32(rKey, i);
                //}
                //this.tbKey.Text = tempKeyStr;
                this.tbKey.Text = string.Join(", ", rKey.Select(x => x.ToString()).ToArray());
                
            }
            else
            {
                rKey = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, rKey);
                this.tbKey.Text = Encoding.UTF8.GetString(rKey);
            }

        }

        private void btnSaveInFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            Assembly asm = Assembly.GetExecutingAssembly();
            string path = Path.GetDirectoryName(asm.Location);

            saveFileDialog1.InitialDirectory = @path;
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string filename = "test" + ".txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
            }
            else
            {
                return;
            }

            byte[] output;
            output = algoritham.Crypt(utf8.GetBytes(tbData.Text));
            this.tbDecode.Text = Encoding.UTF8.GetString(output);
            File.WriteAllBytes(filename, output);
        }

        private void btnDecodeFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            Assembly asm = Assembly.GetExecutingAssembly();
            string path = Path.GetDirectoryName(asm.Location);

            openFile.InitialDirectory = @path;
            openFile.Title = "Save text Files";
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;
            string filename = "test" + ".txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filename = openFile.FileName;
            }
            else
            {
                return;
            }

            byte[] res = File.ReadAllBytes(filename);
            this.tbDecode.Text = Encoding.Default.GetString(res);
            this.tbData.Text = Encoding.Default.GetString(this.algoritham.Decrypt(res));

        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            string res = string.Empty;
            if (algoritham.GetType() == typeof(Knapsack))
            {
                this.checkAndSetForKnapsack();
            }

            if (algoritham.GetType() != typeof(SHA2))
                res = Encoding.Default.GetString(
                algoritham.Crypt(Encoding.UTF8.GetBytes(tbData.Text))
                );
            else
            {
                byte[] hash = algoritham.Crypt(Encoding.Default.GetBytes(tbData.Text));


                for (int i = 0; i < hash.Length; i++)
                {
                    res += string.Format("{0:X2}", hash[i]);
                }

            }

            tbDecode.Text = res;
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {

            if (this.algoritham.GetType() != typeof(SHA2))
            {
                string res = string.Empty;
                byte[] b = algoritham.Decrypt(Encoding.Default.GetBytes(tbDecode.Text));
                res = Encoding.Default.GetString(b);
                tbData.Text = res;
            }
        }

        private void checkAndSetForKnapsack()
        {
            if (tbN.Text.Equals(string.Empty))
            {
                MessageBox.Show("N can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tbM.Text.Equals(string.Empty))
            {
                MessageBox.Show("M can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tbData.Text.Equals(string.Empty))
            {
                MessageBox.Show("You have to enter text to crypt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.specs.Add("n", Encoding.UTF8.GetBytes(tbN.Text));
            this.specs.Add("m", Encoding.UTF8.GetBytes(tbM.Text));

            if (!algoritham.SetAlgorithamProperties(specs))
            {
                MessageBox.Show("Invalid properties!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tbKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnOrgPath_Click(object sender, EventArgs e)
        {
            string path = ChoosePath(this.defaultSrcPath);
            if (path != string.Empty)
            {
                this.tbSrcPath.Text = path;
                this.defaultSrcPath = path;
            }
        }

        private void btnDestPath_Click(object sender, EventArgs e)
        {
            string path = ChoosePath(this.defaultDstPath);
            if (path != string.Empty)
            {
                this.tbDstPath.Text = path;
                this.defaultDstPath = path;
            }
        }

        private string ChoosePath(string path)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = path;
                //fbd.SelectedPath
                //string[] files = Directory.GetFiles(fbd.SelectedPath);
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath;
                }
            }

            return string.Empty;
        }

        private void CreateNewFileWatcher()
        {
            this.watcher = new FileSystemWatcher();
            this.destWatcher = new FileSystemWatcher();


            if (!Directory.Exists(defaultSrcPath)) Directory.CreateDirectory(defaultSrcPath);
            if (!Directory.Exists(defaultDstPath)) Directory.CreateDirectory(defaultDstPath);

            this.watcher.Path = defaultSrcPath;
            this.watcher.IncludeSubdirectories = false;
            this.watcher.Renamed += this.FileWhatcherRenamed;
            this.watcher.Created += this.FileWhatcherCreated;
            this.watcher.Deleted += this.FileWhatcherDeleted;

            // start watching
            this.watcher.EnableRaisingEvents = true;

            this.destWatcher.Path = defaultDstPath;
            this.destWatcher.IncludeSubdirectories = false;
            this.destWatcher.Renamed += this.FileWhatcherRenamed1;
            this.destWatcher.Created += this.FileWhatcherCreated1;
            this.destWatcher.Deleted += this.FileWhatcherDeleted1;

            // start watching
            this.destWatcher.EnableRaisingEvents = true;
        }

        private void FileWhatcherCreated(object sender, FileSystemEventArgs e)
        {
            this.lbFilesToEncrypt.Items.Add(e.FullPath);
        }

        private void FileWhatcherRenamed(object sender, FileSystemEventArgs e)
        {
            string []files = Directory.GetFiles(this.defaultSrcPath);
            this.lbFilesToEncrypt.Items.Clear();
            foreach (string f in files)
            {
                this.lbFilesToEncrypt.Items.Add(f);
            }
        }

        private void FileWhatcherDeleted(object sender, FileSystemEventArgs e)
        {
            string[] files = Directory.GetFiles(this.defaultSrcPath);
            this.lbFilesToEncrypt.Items.Clear();
            foreach (string f in files)
            {
                this.lbFilesToEncrypt.Items.Add(f);
            }
        }

        private void FileWhatcherCreated1(object sender, FileSystemEventArgs e)
        {
            this.lbEncryptedFiles.Items.Add(e.FullPath);
        }

        private void FileWhatcherRenamed1(object sender, FileSystemEventArgs e)
        {
            string[] files = Directory.GetFiles(this.defaultDstPath);
            this.lbEncryptedFiles.Items.Clear();
            foreach (string f in files)
            {
                this.lbEncryptedFiles.Items.Add(f);
            }
        }

        private void FileWhatcherDeleted1(object sender, FileSystemEventArgs e)
        {
            string[] files = Directory.GetFiles(this.defaultDstPath);
            this.lbEncryptedFiles.Items.Clear();
            foreach (string f in files)
            {
                this.lbEncryptedFiles.Items.Add(f);
            }
        }

        private void bntEncryptSelected_Click(object sender, EventArgs e)
        {
            if (this.lbFilesToEncrypt.SelectedItem != null)
            {
                byte[] input = File.ReadAllBytes(this.lbFilesToEncrypt.SelectedItem.ToString());
                byte[] output = this.algoritham.Crypt(input);
                string dst = this.defaultDstPath + "\\" + Path.GetFileName(this.lbFilesToEncrypt.SelectedItem.ToString());
                File.WriteAllBytes(dst, output);
                File.Delete(this.lbFilesToEncrypt.SelectedItem.ToString());
            }
        }

        private void btnDecryptSeleced_Click(object sender, EventArgs e)
        {
            if (this.lbEncryptedFiles.SelectedItem != null)
            {
                byte[] output = File.ReadAllBytes(this.lbEncryptedFiles.SelectedItem.ToString());
                byte[] input = this.algoritham.Decrypt(output);
                string dst = this.defaultSrcPath + "\\" + Path.GetFileName(this.lbEncryptedFiles.SelectedItem.ToString());
                File.WriteAllBytes(dst, input);
                File.Delete(this.lbEncryptedFiles.SelectedItem.ToString());
            }
        }

        private void tbDstPath_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.tbSrcPath, this.defaultSrcPath);
        }

        private void tbSrcPath_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.tbDstPath, this.defaultDstPath);
        }

        private void btnEncryptAll_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(this.defaultSrcPath);

            foreach(string f in files)
            {
                byte[] input = File.ReadAllBytes(f);
                byte[] output = this.algoritham.Crypt(input);
                string dst = this.defaultDstPath + "\\" + Path.GetFileName(f);
                File.WriteAllBytes(dst, output);
                File.Delete(f);
            }
        }

        private void btnDecryptAll_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(this.defaultDstPath);

            foreach (string f in files)
            {
                byte[] output = File.ReadAllBytes(f);
                byte[] input = this.algoritham.Decrypt(output);
                string dst = this.defaultSrcPath + "\\" + Path.GetFileName(f);
                File.WriteAllBytes(dst, input);
                File.Delete(f);
            }

        }
    }
}
