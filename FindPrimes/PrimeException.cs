using System;

namespace Find_Palindromic_Primes.FindPrimes
{
    internal class PrimeException : Exception
    {
        public PrimeException()
        {
            // Intentionally left blank
        }

        public PrimeException(string message) : base(message)
        {
            // Intentionally left blank
        }
    }
}
