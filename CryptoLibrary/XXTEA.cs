using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CryptoLibrary
{
    public class XXTEA : ICryptoLibrary
    {
        private byte[] key;
        private static readonly UTF8Encoding utf8 = new UTF8Encoding();

        private UInt32[] ToLongs(byte[] s)
        {

            // note chars must be within ISO-8859-1 (with Unicode code-point < 256) to fit 4/long
            var l = new UInt32[(int)Math.Ceiling(((decimal)s.Length / 4))];

            // Create an array of long, each long holding the data of 4 characters, if the last block is less than 4
            // characters in length, fill with ascii null values
            for (int i = 0; i < l.Length; i++)
            {
                // Note: little-endian encoding - endianness is irrelevant as long as it is the same in ToBytes()
                l[i] = ((s[i * 4])) +
                       ((i * 4 + 1) >= s.Length ? (UInt32)0 << 8 : ((UInt32)s[i * 4 + 1] << 8)) +
                       ((i * 4 + 2) >= s.Length ? (UInt32)0 << 16 : ((UInt32)s[i * 4 + 2] << 16)) +
                       ((i * 4 + 3) >= s.Length ? (UInt32)0 << 24 : ((UInt32)s[i * 4 + 3] << 24));
            }

            return l;
        }

        private byte[] ToBytes(UInt32[] l)
        {
            byte[] b = new byte[l.Length * 4];

            // Split each long value into 4 separate characters (bytes) using the same format as ToLongs()
            for (Int32 i = 0; i < l.Length; i++)
            {
                b[(i * 4)] = (byte)(l[i] & 0xFF);
                b[(i * 4) + 1] = (byte)(l[i] >> (8 & 0xFF));
                b[(i * 4) + 2] = (byte)(l[i] >> (16 & 0xFF));
                b[(i * 4) + 3] = (byte)(l[i] >> (24 & 0xFF));
            }
            return b;
        }

        public byte[] Crypt(byte[] input)
        {
            // if there is no input
            if (input.Length < 4)
                throw new Exception("Too small amount of data.");

            var v = ToLongs(input);

            if (v.Length == 1) { v[0] = 0; }

            // Simply convert first 16 chars of password as key
            var k = ToLongs(key);

            // Use UInt32 as the original is based on 'unsigned long' in C, which is equiv to UInt32 in .Net (and not ulong)
            UInt32 n = (UInt32)v.Length,
                   z = v[n - 1],
                   y = v[0],
                   delta = 0x9e3779b9,
                   e,
                   q = (UInt32)(6 + (52 / n)),
                   sum = 0,
                   p = 0;

            while (q-- > 0)
            {
                sum += delta;
                e = sum >> 2 & 3;

                for (p = 0; p < (n - 1); p++)
                {
                    y = v[(p + 1)];
                    z = v[p] += (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z);
                }

                y = v[0];
                z = v[n - 1] += (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z);
            }
            
            return ToBytes(v);
        }

        public byte[] Decrypt(byte[] output)
        {

            if (output.Length <= 4) { byte[] r = new byte[1]; return r; }

            var v = ToLongs(output);
            var k = ToLongs(key);

            UInt32 n = (UInt32)v.Length,
                   z = v[n - 1],
                   y = v[0],
                   delta = 0x9e3779b9,
                   e,
                   q = (UInt32)(6 + (52 / n)),
                   sum = q * delta,
                   p = 0;

            while (sum != 0)
            {
                e = sum >> 2 & 3;

                for (p = (n - 1); p > 0; p--)
                {
                    z = v[p - 1];
                    y = v[p] -= (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z);
                }

                z = v[n - 1];
                y = v[0] -= (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z);

                sum -= delta;
            }
            
            return ToBytes(v);
        }

        public byte[] GenerateRandomIV()
        {
            return null;
        }

        public byte[] GenerateRandomKey()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            var bulder = new StringBuilder();
            while (bulder.Length < 16)
            {
                bulder.Append(rnd.Next(10).ToString());
            }
            this.key = Encoding.UTF8.GetBytes(bulder.ToString());
            return key;
        }

        public bool SetAlgorithamProperties(IDictionary<string, byte[]> specArguments)
        {
            return true;
        }

        public bool SetIV(byte[] input)
        {
            return true;
        }

        public bool SetKey(byte[] input)
        {
            if (input.Length < 16)
                return false;
        
            key = input;
            return true;
        }

        public override string ToString() { return "XXTEA"; }
    }
}
