using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CryptoService
{
    [ServiceContract]
    public interface ICryptoService
    {
        [OperationContract]
        void Upload(byte []file);

        [OperationContract]
        byte[] LoadFile(string filename);

        [OperationContract]
        string Hello(string name);

    }


    [MessageContract]
    public class UploadReply
    {
        [MessageBodyMember] public bool UploadSuccess;
    }

    [MessageContract]
    public class FileDetails : IDisposable
    {
        [MessageHeader(MustUnderstand = true)] public string FileName;

        [MessageBodyMember(Order = 1)] public System.IO.Stream FileStreamReader;

        public void Dispose()
        {
            //To be sure that stream is closed on server side
            if (FileStreamReader == null) return;
            FileStreamReader.Close();
            FileStreamReader = null;
        }
    }

    [MessageContract]
    public class DownloadFile
    {
        [MessageBodyMember] public string FileName;
    }
}
