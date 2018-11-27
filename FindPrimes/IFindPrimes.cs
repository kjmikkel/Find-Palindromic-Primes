using System.Collections.Generic;

namespace Find_Palindromic_Primes.FindPrimes
{
    public interface IFindPrimes
    {
        /// <summary>
        /// Find all the prime numbers in an interval
        /// </summary>
        /// <param name="from">The start of the interval</param>
        /// <param name="to">The end of the interval</param>
        /// <returns>A list of primes in the given interval</returns>
        IEnumerable<int> FindPrimes(int from, int to);
    }
}
