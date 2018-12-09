using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace CryptoLibrary
{
    public class SimpleSubstitution : ICryptoLibrary
    {
        Dictionary<string, byte> coding;
        Dictionary<byte, string> decoding;
        private static readonly UTF8Encoding utf8 = new UTF8Encoding();

        string origin = string.Empty;

        public SimpleSubstitution()
        {
            this.coding = new Dictionary<string, byte>();
            this.decoding = new Dictionary<byte, string>();

            byte[] b = new byte[256];
            for(short i = 0; i < 256;i++)
            {
                b[i] = (byte)i;
            }

            origin = Encoding.Default.GetString(b);

        }

        public byte[] Crypt(byte[] input)
        {
            string tempText = System.Text.Encoding.UTF8.GetString(input);

            input = utf8.GetBytes(tempText);

            byte[] res = new byte[input.Length];
            char[] text = Encoding.UTF8.GetChars(input);

            for(int i = 0; i < input.Length; i++)
            {
                if(coding.ContainsKey(text[i].ToString()))
                {
                    res[i] = coding[text[i].ToString()];
                }
            }

            return res;
        }

        public byte[] Decrypt(byte[] output)
        {
            string res = string.Empty;

          
            for (int i = 0; i < output.Length; i++)
            {
                if (decoding.ContainsKey(output[i]))
                    res += decoding[output[i]];
            }

            return utf8.GetBytes(res);
        }

        public byte[] GenerateRandomIV()
        {
            return null; 
        }

        public byte[] GenerateRandomKey()
        { 
            this.coding = new Dictionary<string, byte>();
            this.decoding = new Dictionary<byte, string>();

            Random random = new Random((int)DateTime.Now.Ticks);

            byte[] nKey = Encoding.Default.GetBytes(origin.ToCharArray().OrderBy(x => random.Next()).ToArray());
           

            for(int i = 0; i < origin.Length;i++)
            {
                this.coding.Add(origin[i].ToString(), nKey[i]);
            }

            this.decoding = this.coding.ToDictionary(kp => kp.Value, kp => kp.Key);

            return nKey;
        }

        public bool SetAlgorithamProperties(IDictionary<string, byte[]> specArguments)
        {
            byte[] keys;
            specArguments.TryGetValue("key", out keys);

            if (keys.Length != 26)
                return false;
            this.coding = new Dictionary<string, byte>();
            this.decoding = new Dictionary<byte, string>();
            int i = 0;
            foreach(byte k in keys)
            {
                this.coding.Add(origin[i].ToString(),k);
                this.decoding.Add(k, origin[i].ToString());
                i++;
            }
            return true;
        }

        public bool SetIV(byte[] input)
        {
            throw new NotImplementedException();
        }

        public bool SetKey(byte[] input)
        {
            if (input.Length != 26)
                return false;
            this.coding = new Dictionary<string, byte>();
            this.decoding = new Dictionary<byte, string>();
            for(int i = 0; i < input.Length; i++)
            {
                coding.Add(origin[i].ToString(), input[i]);
                decoding.Add(input[i], origin[i].ToString());
            }
            return true;
        }
    }
}
