using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenTokenization.Service.Utilities.Implementation
{
    public class NumericTokenizer : TokenizerBase
    {
        private readonly char[] _numbers;

        public NumericTokenizer()
        {
            _numbers = "1234567890".ToCharArray();
        }

        public string GetUniqueKey(int size)
        {
            return base.GetUniqueKey(_numbers, size);
        }
    }
}
