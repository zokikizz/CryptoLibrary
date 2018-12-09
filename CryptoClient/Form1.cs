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
        private ICryptoLibrary algorithm;

        private static readonly UTF8Encoding utf8 = new UTF8Encoding();

        public CryptoClientForm()
        {
            InitializeComponent();
        }

        private void CryptoClientForm_Load(object sender, EventArgs e)
        {
            // add algoritams in drop down
            ToolStripMenuItem menu = new ToolStripMenuItem("Algorithams");

            ToolStripMenuItem item = new ToolStripMenuItem("Substitution");
            ICryptoLibrary alg = new SimpleSubstitution();
            item.Tag = alg;
            this.algorithm = alg;
            menu.DropDownItems.Add(item);

            alg = new XXTEA();
            item = new ToolStripMenuItem("XXTEA");
            item.Tag = alg;
            menu.DropDownItems.Add(item);

            alg = new SHA2();
            item = new ToolStripMenuItem("SHA2");
            item.Tag = alg;
            menu.DropDownItems.Add(item);
            // TODO: add Knapsack 

            menu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnClickedItem);
            this.msOptions.Items.Add(menu);


            this.Init();

        }

        private void Init()
        {
            #region Simple Substitution init

            //Dictionary <char,char> cast 
            char[] test = new char[26];
            for (int i = 65; i < (65 + 26); i++)
            {
                test[i - 65] = (char)i;
            }

            this.tbData.Text = new string(test);
            
            this.tbKey.Text = Encoding.Default.GetString(this.algorithm.GenerateRandomKey());

            #endregion
        }

        private void OnClickedItem(object sender, ToolStripItemClickedEventArgs e)
        {
            this.algorithm = (ICryptoLibrary)e.ClickedItem.Tag;
            byte[] key;
            if (this.algorithm.GetType() != typeof(SHA2))
                key = this.algorithm.GenerateRandomKey();
            else
                key = ((SHA2)this.algorithm).GetKey();
            this.tbKey.Text = System.Text.Encoding.UTF8.GetString(key);
        }

        private void btnSetKey_Click(object sender, EventArgs e)
        {
            this.algorithm.SetKey(Encoding.UTF8.GetBytes(this.tbKey.Text));
        }

        private void btnRandomGenerateKey_Click(object sender, EventArgs e)
        {
            this.tbKey.Text = Encoding.UTF8.GetString(this.algorithm.GenerateRandomKey());
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
            output = algorithm.Crypt(utf8.GetBytes(tbData.Text));
            this.tbDecode.Text = Encoding.Default.GetString(output);
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
            this.tbData.Text = Encoding.Default.GetString(this.algorithm.Decrypt(res));

        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            string res = string.Empty;
            if (algorithm.GetType() != typeof(SHA2))
                res = Encoding.Default.GetString(
                algorithm.Crypt(Encoding.Default.GetBytes(tbData.Text))
                );
            else
            {
                byte[] hash = algorithm.Crypt(Encoding.Default.GetBytes(tbData.Text));
                

                for (int i = 0; i < hash.Length; i++)
                {
                    res += string.Format("{0:X2}", hash[i]);
                }

            }

            tbDecode.Text = res;
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {

            if (this.algorithm.GetType() != typeof(SHA2))
            { 
                string res = Encoding.Default.GetString(
                algorithm.Decrypt(Encoding.Default.GetBytes(tbDecode.Text))
                );
                tbData.Text = res;
            }
        }


    }
}
