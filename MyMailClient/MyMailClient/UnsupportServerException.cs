using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMailClient
{
    class UnsupportServerException : Exception
    {
        public UnsupportServerException(string str)
        {
           Message=str;
        }

        public override string Message { get; }
    }
}
