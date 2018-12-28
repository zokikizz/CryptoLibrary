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
using System.IO;

namespace CryptoClient
{
    public partial class CloudForm : MaterialSkin.Controls.MaterialForm
    {
        string clientDir;
        public CloudForm(string dir)
        {
            clientDir = dir;
            InitializeComponent();
        }

        private void CloudForm_Load(object sender, EventArgs e)
        {
            string [] files = Directory.GetFiles(clientDir);

            foreach (string f in files)
                cbClient.Items.Add(f);

            var cloudProxy = new CryptoService.CryptoServiceClient();
            files = cloudProxy.GetFilesNames();

            foreach (string f in files)
                cbCloud.Items.Add(f);

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // ok, its working
            string[] checkedFiles = cbClient.CheckedItems.Cast<string>().ToArray();
            var cloudProxy = new CryptoService.CryptoServiceClient();
            
            foreach (string s in checkedFiles)
            {
                string fileName = Path.GetFileName(s);

                using (var stream = new FileStream(s, FileMode.Open, FileAccess.Read))
                {
                    bool resultOfUpload = cloudProxy.Upload(fileName, stream);
                }
            }

            string [] files = cloudProxy.GetFilesNames();
            cbCloud.Items.Clear();
            foreach (string f in files)
                cbCloud.Items.Add(f);
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            // ok, its working
            string[] checkedFiles = cbClient.CheckedItems.Cast<string>().ToArray();

            foreach (string t in checkedFiles)
                File.Delete(t);
            string[] files = Directory.GetFiles(clientDir);

            cbClient.Items.Clear();
            foreach (string f in files)
                cbClient.Items.Add(f);
        }

        private void btnDeleteCloud_Click(object sender, EventArgs e)
        {
            // ok, its working
            string[] checkedFiles = cbCloud.CheckedItems.Cast<string>().ToArray();

            var cloudProxy = new CryptoService.CryptoServiceClient();

            foreach (string s in checkedFiles)
            {
                cloudProxy.DeleteFile(s);
            }

            string[] files = cloudProxy.GetFilesNames();
            cbCloud.Items.Clear();
            foreach (string f in files)
                cbCloud.Items.Add(f);
        }

        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            // ok, its working
            string[] checkedFiles = cbCloud.CheckedItems.Cast<string>().ToArray();

            var cloudProxy = new CryptoService.CryptoServiceClient();

            foreach(string s in checkedFiles)
            {
                string temp = s;
                Stream inputStream = cloudProxy.LoadFile(ref temp);
                int blockSize = 2048;

                if (File.Exists(temp))
                    File.Delete(temp);

                using (FileStream writeStream = new FileStream(clientDir + "\\" + temp, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[blockSize];

                    do
                    {
                        var bytesRead = inputStream.Read(buffer, 0, buffer.Length);

                        if (bytesRead == 0) break;

                        //Then it's last block
                        if (bytesRead < blockSize)
                        {
                            var t = new byte[bytesRead];
                            Array.Copy(buffer, t, bytesRead);
                            buffer = t;
                        }

                        writeStream.Write(buffer, 0, buffer.Length);

                    } while (true);

                    writeStream.Close();
                }
            }

            string[] files = Directory.GetFiles(clientDir);
            cbClient.Items.Clear();
            foreach (string f in files)
                cbClient.Items.Add(f);

        }
    }
}
