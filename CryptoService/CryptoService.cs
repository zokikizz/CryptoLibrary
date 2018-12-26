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
        private string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CloudFiles");

        public CryptoService()
        {
             Directory.CreateDirectory(folderPath);
        }
        public string Hello(string name)
        {
            return "Hello " + name;
        }

        public byte[] LoadFile(string filename)
        {
            return null;
        }

        public void Upload(byte[] file)
        {
            return;
        }

        public bool DeleteFile(string fileName)
        {
            string filePath = Path.Combine(folderPath, fileName);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);

                if (!File.Exists(filePath))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public FileDetails DownloadFile(DownloadFile details)
        {
            var filePath = Path.Combine(folderPath, details.FileName);

            // Check if file exists
            if (!File.Exists(filePath)) return null;

            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            // Return stream
            return new FileDetails
            {
                FileName = details.FileName,
                FileStreamReader = stream
            };
        }

        public string[] GetUploadedFilesNames()
        {
            return Directory.GetFiles(folderPath);
        }

        public UploadReply UploadFile(FileDetails details)
        {
            string filePath = Path.Combine(folderPath, details.FileName);
            int numberOfSameFile = 0;

            while (File.Exists(filePath))
            {
                numberOfSameFile++;
                string[] fileNameSplited = details.FileName.Split('.');
                filePath = Path.Combine(folderPath, fileNameSplited[0] + "[" + numberOfSameFile + "]." + fileNameSplited[1]);
            }

            using (FileStream wr = new FileStream(filePath, FileMode.CreateNew, FileAccess.Write))
            {
                do
                {
                    byte[] buffer = new byte[blockSize];

                    int bytesRead = details.FileStreamReader.Read(buffer, 0, blockSize);

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
