using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary
{
    public class SHA2 : ICryptoLibrary
    {
        #region Private Attributes

        // Initial hash values
        static readonly uint[] initalHashValue = new uint[8] {
            0x6A09E667, 0xBB67AE85, 0x3C6EF372, 0xA54FF53A, 0x510E527F, 0x9B05688C, 0x1F83D9AB, 0x5BE0CD19
        };

        // keys (every element of array is a key for one round)
        static readonly uint[] constantsK = new uint[64] {
            0x428A2F98, 0x71374491, 0xB5C0FBCF, 0xE9B5DBA5, 0x3956C25B, 0x59F111F1, 0x923F82A4, 0xAB1C5ED5,
            0xD807AA98, 0x12835B01, 0x243185BE, 0x550C7DC3, 0x72BE5D74, 0x80DEB1FE, 0x9BDC06A7, 0xC19BF174,
            0xE49B69C1, 0xEFBE4786, 0x0FC19DC6, 0x240CA1CC, 0x2DE92C6F, 0x4A7484AA, 0x5CB0A9DC, 0x76F988DA,
            0x983E5152, 0xA831C66D, 0xB00327C8, 0xBF597FC7, 0xC6E00BF3, 0xD5A79147, 0x06CA6351, 0x14292967,
            0x27B70A85, 0x2E1B2138, 0x4D2C6DFC, 0x53380D13, 0x650A7354, 0x766A0ABB, 0x81C2C92E, 0x92722C85,
            0xA2BFE8A1, 0xA81A664B, 0xC24B8B70, 0xC76C51A3, 0xD192E819, 0xD6990624, 0xF40E3585, 0x106AA070,
            0x19A4C116, 0x1E376C08, 0x2748774C, 0x34B0BCB5, 0x391C0CB3, 0x4ED8AA4A, 0x5B9CCA4F, 0x682E6FF3,
            0x748F82EE, 0x78A5636F, 0x84C87814, 0x8CC70208, 0x90BEFFFA, 0xA4506CEB, 0xBEF9A3F7, 0xC67178F2
        };

        public byte[] GetKey()
        {
            byte[] result = new byte[constantsK.Length * sizeof(uint)];
            Buffer.BlockCopy(constantsK, 0, result, 0, result.Length);
            return result;
        }

        //Struct that saves data
        struct SHA256_CTX
        {
            public byte[] data; // Data to hash
            public uint datalen;    // Data length
            public uint[] bitlen;
            public uint[] state;  // Initial states
        }

        #endregion

        #region Implemented Interface Functions

        public byte[] Crypt(byte[] input)
        {
            SHA256_CTX ctx = new SHA256_CTX();
            ctx.data = new byte[64];
            ctx.bitlen = new uint[2];
            ctx.state = new uint[8];

            byte[] hash = new byte[32];
            string hashStr = string.Empty;

            SHA256Init(ref ctx);
            SHA256Update(ref ctx, input, (uint)input.Length);
            SHA256Final(ref ctx, hash);

            return hash;
        }

        #region Not Implemented Functions

        public byte[] Decrypt(byte[] output)
        {
            throw new NotImplementedException();
        }

        public byte[] GenerateRandomIV()
        {
            throw new NotImplementedException();
        }

        public byte[] GenerateRandomKey()
        {
            throw new NotImplementedException();
        }

        public bool SetAlgorithamProperties(IDictionary<string, byte[]> specArguments)
        {
            throw new NotImplementedException();
        }

        public bool SetIV(byte[] input)
        {
            throw new NotImplementedException();
        }

        public bool SetKey(byte[] input)
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion

        #region Helper Functions

        static void SHA256Init(ref SHA256_CTX ctx)
        {
            ctx.datalen = 0;
            ctx.bitlen[0] = 0;
            ctx.bitlen[1] = 0;
            ctx.state[0] = initalHashValue[0];
            ctx.state[1] = initalHashValue[1];
            ctx.state[2] = initalHashValue[2];
            ctx.state[3] = initalHashValue[3];
            ctx.state[4] = initalHashValue[4];
            ctx.state[5] = initalHashValue[5];
            ctx.state[6] = initalHashValue[6];
            ctx.state[7] = initalHashValue[7];
        }

        static void SHA256Update(ref SHA256_CTX ctx, byte[] data, uint len)
        {
            for (uint i = 0; i < len; ++i)
            {
                ctx.data[ctx.datalen] = data[i];
                ctx.datalen++;

                if (ctx.datalen == 64)
                {
                    SHA256Transform(ref ctx, ctx.data);
                    DBL_INT_ADD(ref ctx.bitlen[0], ref ctx.bitlen[1], 512);
                    ctx.datalen = 0;
                }
            }
        }

        static void SHA256Transform(ref SHA256_CTX ctx, byte[] data)
        {
            uint a, b, c, d, e, f, g, h, i, j, t1, t2;
            uint[] m = new uint[64];

            for (i = 0, j = 0; i < 16; ++i, j += 4)
                m[i] = (uint)((data[j] << 24) | (data[j + 1] << 16) | (data[j + 2] << 8) | (data[j + 3]));

            for (; i < 64; ++i)
                m[i] = SIG1(m[i - 2]) + m[i - 7] + SIG0(m[i - 15]) + m[i - 16];

            a = ctx.state[0];
            b = ctx.state[1];
            c = ctx.state[2];
            d = ctx.state[3];
            e = ctx.state[4];
            f = ctx.state[5];
            g = ctx.state[6];
            h = ctx.state[7];

            for (i = 0; i < 64; ++i)
            {
                t1 = h + EP1(e) + CH(e, f, g) + constantsK[i] + m[i];
                t2 = EP0(a) + MAJ(a, b, c);
                h = g;
                g = f;
                f = e;
                e = d + t1;
                d = c;
                c = b;
                b = a;
                a = t1 + t2;
            }

            ctx.state[0] += a;
            ctx.state[1] += b;
            ctx.state[2] += c;
            ctx.state[3] += d;
            ctx.state[4] += e;
            ctx.state[5] += f;
            ctx.state[6] += g;
            ctx.state[7] += h;
        }

        static void SHA256Final(ref SHA256_CTX ctx, byte[] hash)
        {
            uint i = ctx.datalen;

            if (ctx.datalen < 56)
            {
                ctx.data[i++] = 0x80;

                while (i < 56)
                    ctx.data[i++] = 0x00;
            }
            else
            {
                ctx.data[i++] = 0x80;

                while (i < 64)
                    ctx.data[i++] = 0x00;

                SHA256Transform(ref ctx, ctx.data);
            }

            DBL_INT_ADD(ref ctx.bitlen[0], ref ctx.bitlen[1], ctx.datalen * 8);
            ctx.data[63] = (byte)(ctx.bitlen[0]);
            ctx.data[62] = (byte)(ctx.bitlen[0] >> 8);
            ctx.data[61] = (byte)(ctx.bitlen[0] >> 16);
            ctx.data[60] = (byte)(ctx.bitlen[0] >> 24);
            ctx.data[59] = (byte)(ctx.bitlen[1]);
            ctx.data[58] = (byte)(ctx.bitlen[1] >> 8);
            ctx.data[57] = (byte)(ctx.bitlen[1] >> 16);
            ctx.data[56] = (byte)(ctx.bitlen[1] >> 24);
            SHA256Transform(ref ctx, ctx.data);
            for (i = 0; i < 4; ++i)
            {
                hash[i] = (byte)(((ctx.state[0]) >> (int)(24 - i * 8)) & 0x000000ff);
                hash[i + 4] = (byte)(((ctx.state[1]) >> (int)(24 - i * 8)) & 0x000000ff);
                hash[i + 8] = (byte)(((ctx.state[2]) >> (int)(24 - i * 8)) & 0x000000ff);
                hash[i + 12] = (byte)((ctx.state[3] >> (int)(24 - i * 8)) & 0x000000ff);
                hash[i + 16] = (byte)((ctx.state[4] >> (int)(24 - i * 8)) & 0x000000ff);
                hash[i + 20] = (byte)((ctx.state[5] >> (int)(24 - i * 8)) & 0x000000ff);
                hash[i + 24] = (byte)((ctx.state[6] >> (int)(24 - i * 8)) & 0x000000ff);
                hash[i + 28] = (byte)((ctx.state[7] >> (int)(24 - i * 8)) & 0x000000ff);
            }
        }

        static void DBL_INT_ADD(ref uint a, ref uint b, uint c)
        {
            if (a > 0xffffffff - c) ++b; a += c;
        }

        static uint ROTLEFT(uint a, byte b)
        {
            return ((a << b) | (a >> (32 - b)));
        }

        static uint ROTRIGHT(uint a, byte b)
        {
            return (((a) >> (b)) | ((a) << (32 - (b))));
        }

        static uint CH(uint x, uint y, uint z)
        {
            return (((x) & (y)) ^ (~(x) & (z)));
        }

        static uint MAJ(uint x, uint y, uint z)
        {
            return (((x) & (y)) ^ ((x) & (z)) ^ ((y) & (z)));
        }

        static uint EP0(uint x)
        {
            return (ROTRIGHT(x, 2) ^ ROTRIGHT(x, 13) ^ ROTRIGHT(x, 22));
        }

        static uint EP1(uint x)
        {
            return (ROTRIGHT(x, 6) ^ ROTRIGHT(x, 11) ^ ROTRIGHT(x, 25));
        }

        static uint SIG0(uint x)
        {
            return (ROTRIGHT(x, 7) ^ ROTRIGHT(x, 18) ^ ((x) >> 3));
        }

        static uint SIG1(uint x)
        {
            return (ROTRIGHT(x, 17) ^ ROTRIGHT(x, 19) ^ ((x) >> 10));
        }

        #endregion
    }
}
