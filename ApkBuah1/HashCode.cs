using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ApkBuah1
{
    class HashCode
    {
        public string PashHash(string data)
        {
            SHA1 sha = SHA1.Create();
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(data));

            StringBuilder resultValues = new StringBuilder();
            for(int i = 0; i<hashdata.Length; i++)
            {
                resultValues.Append(hashdata[i].ToString());
            }
            return resultValues.ToString();
        }
    }
}
