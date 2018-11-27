using System;

namespace Find_Palindromic_Primes.Palindrome
{
    /// <summary>
    /// This class checks whether a number is a palindrome in binary
    /// </summary>
    internal class BinaryPalindromeChecker : PalindromeChecker
    {
        // When dealing with binary one could consider whether to use the strategy pattern to decide whether it should use big endian or little endian, but since
        // we are looking for palindromes, this does not matter

        /// <summary>
        /// Get the textual representation of integer in binary
        /// </summary>
        /// <param name="number">The number to be representation in binary</param>
        /// <returns>The number as a binary string</returns>
        public override string TextualRepresentation(int number)
        {
            return Convert.ToString(number, 2);
        }


    }
}
