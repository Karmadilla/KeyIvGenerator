using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KeyAndIvGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            RijndaelManaged rm = new RijndaelManaged();
            rm.GenerateKey();
            rm.GenerateIV();
            string key = Convert.ToBase64String(rm.Key);
            string iv = Convert.ToBase64String(rm.IV);
        }
    }
}
