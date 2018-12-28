using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CryptoService
{
    public class CryptoService : ICryptoService
    {

        private int blockSize = 2048;
        private string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), "CloudFiles");

        public bool DeleteFile(string fileName)
        {
            File.Delete(folderPath + "\\" + fileName);
            return true;
        }

        public string[] GetFilesNames()
        {
            string[] filesFullPath = Directory.GetFiles(folderPath);
            string[] files = new string[filesFullPath.Length];
            int i = 0;
            foreach(string s in filesFullPath)
                files[i++] = Path.GetFileName(s);
            return files;
        }

        //Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CloudFiles");


        public FileDetails LoadFile(DownloadFile details)
        {
            string filePath = Path.Combine(folderPath, details.FileName);

            if (!File.Exists(filePath))
                return null;


            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            // Return stream
            return new FileDetails
            {
                FileName = details.FileName,
                FileStreamReader = stream
            };
        }

        public UploadReply Upload(FileDetails file)
        {
            string filePath = Path.Combine(folderPath, file.FileName);
            int numberOfSameFile = 0;

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            while (File.Exists(filePath))
            {
                numberOfSameFile++;
                string[] fileNameSplited = file.FileName.Split('.');
                filePath = Path.Combine(folderPath, fileNameSplited[0] + "[" + numberOfSameFile + "]." + fileNameSplited[1]);
            }

            using (FileStream wr = new FileStream(filePath, FileMode.CreateNew, FileAccess.Write))
            {
                do
                {
                    byte[] buffer = new byte[blockSize];

                    int bytesRead = file.FileStreamReader.Read(buffer, 0, blockSize);

                    //If there is no more blocks brake while loop
                    if (bytesRead == 0)
                        break;

                    //When last block is uploaded
                    if (bytesRead < blockSize)
                    {
                        var temp = new byte[bytesRead];
                        Array.Copy(buffer, temp, bytesRead);
                        buffer = temp;
                    }


                    wr.Write(buffer, 0, buffer.Length);

                } while (true);
            }

            if (File.Exists(filePath))
                return new UploadReply() { UploadSuccess = true };
            else
                return new UploadReply() { UploadSuccess = false };
        }
    }
}
