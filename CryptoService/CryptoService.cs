using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CryptoService
{
    public class CryptoService : ICryptoService
    {
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
    }
}
