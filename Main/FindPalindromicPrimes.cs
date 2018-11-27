using Find_Palindromic_Primes.FindPrimes;
using Find_Palindromic_Primes.Palindrome;
using System.Collections.Generic;
using System.Linq;

namespace Find_Palindromic_Primes.Main
{
    /// <summary>
    /// Class that helps finding the palindromic primes
    /// </summary>
    internal class FindPalindromicPrimes
    {
        /// <summary>
        /// Find the palindromic primes
        /// </summary>
        /// <param name="primes">The algorithm we are using to find the primes with</param>
        /// <param name="palindromicChecker">The object that is going to check if the primes are palindromic in its respective base</param>
        /// <param name="from">The start of the interval we are to find primes in</param>
        /// <param name="to">The end of the interval we are going to find primes in</param>
        /// <returns></returns>
        public IEnumerable<int> FindPrimes(IFindPrimes primes, PalindromeChecker palindromicChecker, int from, int to)
        {
            if (primes is null)
            {
                throw new FindPalindromicPrimesException("The prime finder algorithm cannot be null");
            }
            if (palindromicChecker == null)
            {
                throw new FindPalindromicPrimesException("The palindromic check algorithm cannot be null");
            }

            IEnumerable<int> primesInInterval = primes.FindPrimes(from, to);
            return primesInInterval.Where(p => palindromicChecker.IsPalindrome(p));
        }
    }
}
