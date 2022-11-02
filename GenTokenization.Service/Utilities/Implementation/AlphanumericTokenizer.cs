using GenTokenization.Service.Utilities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GenTokenization.Service.Utilities.Implementation
{
    public class AlphanumericTokenizer : TokenizerBase
    {
        private readonly char[] _chars;

        public AlphanumericTokenizer()
        {
            _chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
        }

        public string GetUniqueKey(int size)
        {
            return base.GetUniqueKey(_chars, size);
        }
    }
}
