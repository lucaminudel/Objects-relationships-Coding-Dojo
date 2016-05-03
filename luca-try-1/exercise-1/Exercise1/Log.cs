using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Log
    {
        private string _log = string.Empty;

        public void Append(string message)
        {
            _log += message + "\n";
        }

        public string Read()
        {
            return _log;
        }
    }
}
