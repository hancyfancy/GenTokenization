using GenTokenization.Service.Utilities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GenTokenization.Service.Utilities.Implementation
{
    public abstract class TokenizerBase
    {
        public string GetUniqueKey(char[] dataset, int size)
        {
            try
            {
                byte[] data = new byte[4 * size];
                using (var crypto = RandomNumberGenerator.Create())
                {
                    crypto.GetBytes(data);
                }
                StringBuilder result = new StringBuilder(size);
                for (int i = 0; i < size; i++)
                {
                    var rnd = BitConverter.ToUInt32(data, i * 4);
                    var idx = rnd % dataset.Length;

                    result.Append(dataset[idx]);
                }

                return result.ToString();
            }
            catch (Exception e)
            {
                return default;
            }
        }
    }
}
