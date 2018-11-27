using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Palindromic_Primes.Output
{
    public class OutputException : Exception
    {
        public OutputException() : base()
        {
            // Left blank on purpose
        }

        public OutputException(string message) : base(message)
        {
            // Left blank on purpose
        }
    }
}
