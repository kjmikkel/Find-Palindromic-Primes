using Find_Palindromic_Primes.Palindrome;
using System.Collections.Generic;

namespace Find_Palindromic_Primes.Output
{
    /// <summary>
    /// The interface to provide the output for the program
    /// </summary>
    public interface IOutput
    {
        /// <summary>
        /// Report the palindrome (as well as their representation in the base they were checked for bing a palindrome in)
        /// </summary>
        /// <param name="primes">The primes to be reported</param>
        /// <param name="palindromeChecker">The palindromic checker (to report them in their base)</param>
        void ReportPalindromeData(IEnumerable<int> primes, PalindromeChecker palindromeChecker);

        /// <summary>
        /// Report the palindromic primes
        /// </summary>
        /// <param name="primes">The primes to be reported</param>
        void ReportPalindromeData(IEnumerable<int> primes);

        /// <summary>
        /// Report the error messages
        /// </summary>
        /// <param name="errors">The errors to be reported</param>
        void ReportPalindromeErrors(IEnumerable<string> errors);

        /// <summary>
        /// Report the help information
        /// </summary>
        /// <param name="helpInformation">The help to be reported</param>
        void ReportHelpInformation(string helpInformation);
    }
}
