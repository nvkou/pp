using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp
{
    interface IChecksum
    {
        string Generate_checksum(Dictionary<string, string> parameter);
        bool Vaileade_checksum(Dictionary<string, string> parameter, string hmac);
    }
}
