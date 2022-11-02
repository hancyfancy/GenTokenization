using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenTokenization.Service.Utilities.Interface
{
    public interface ITokenizer
    {
        string GetUniqueKey(char[] dataset, int size);
    }
}
