using System.Linq;

namespace Find_Palindromic_Primes.Palindrome
{
    /// <summary>
    /// The abstract class that will check whether a number is a palindrome
    /// </summary>
    public abstract class PalindromeChecker
    {
        /// <summary>
        /// Get the textual representation of the number in the given base
        /// </summary>
        /// <param name="number">The number to be represented in the given base</param>
        /// <returns>The number returned in the correct base as a string</returns>
        public abstract string TextualRepresentation(int number);

        /// <summary>
        /// Check whether a given number is a palindrome in the given base
        /// </summary>
        /// <param name="number">The number to be checked</param>
        /// <returns>Whether or not the number is a palindrome in the given base</returns>
        public bool IsPalindrome(int number)
        {
            if (number < 0)
            {
                throw new PalindromeException($"A palindrome number cannot be negative: {number}");
            }

            char[] candidate = TextualRepresentation(number).ToArray();

            bool isPalindrome = true;
            for(int i = 0; i < candidate.Length / 2; i++)
            {
                isPalindrome &= candidate[i] == candidate[candidate.Length - 1 - i];
            }

            return isPalindrome;
        }
    }
}
