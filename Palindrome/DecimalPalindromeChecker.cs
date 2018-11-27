namespace Find_Palindromic_Primes.Palindrome
{
    /// <summary>
    /// This class checks whether a number is a palindrome in decimal
    /// </summary>
    internal class DecimalPalindromeChecker : PalindromeChecker
    {
        /// <summary>
        /// Get the textual representation of integer in decimal
        /// </summary>
        /// <param name="number">The number to be representation in decimal</param>
        /// <returns>The number as a decimal string</returns>
        public override string TextualRepresentation(int number)
        {
            return number.ToString();
        }
    }
}
