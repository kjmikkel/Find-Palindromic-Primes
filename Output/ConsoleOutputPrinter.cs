using System;
using System.Collections.Generic;
using System.Linq;
using Find_Palindromic_Primes.Palindrome;

namespace Find_Palindromic_Primes.Output
{
    /// <summary>
    /// An output system to print the primes to the console
    /// </summary>
    internal class ConsoleOutputPrinter : IOutput
    {
        /// <summary>
        /// Print the help information
        /// </summary>
        /// <param name="helpInformation">The help information to be printed to the console</param>
        public void ReportHelpInformation(string helpInformation)
        {
            if (helpInformation is null)
            {
                throw new OutputException("The help information is null, this should not be so.");
            }

            Console.WriteLine(helpInformation);
        }

        /// <summary>
        /// Print the palindromic primes to the console
        /// </summary>
        /// <param name="primes">The primes to be printed to the console</param>
        public void ReportPalindromeData(IEnumerable<int> primes)
        {
            if (primes is null)
            {
                throw new OutputException("The reported prime numbers are null - please check range and sign of 'to' and 'from'.");
            }

            Console.WriteLine(string.Join(", ", primes));
        }

        /// <summary>
        /// Print the palindromice primes to the console (as well as their representation in the base they were checked for being a palindrome in)
        /// </summary>
        /// <param name="primes">The primes to be printed to the console</param>
        /// <param name="palindromeChecker">The palindromic checker (to print them in their base)</param>
        public void ReportPalindromeData(IEnumerable<int> primes, PalindromeChecker palindromeChecker)
        {
            if (primes is null)
            {
                throw new OutputException("The reported prime numbers are null - please check range and sign of 'to' and 'from'.");
            }
            if (palindromeChecker is null)
            {
                throw new OutputException("The palindrome checker cannot be null");
            }


            IEnumerable<string> strPrimes = primes.Select(p => $"{p} ({palindromeChecker.TextualRepresentation(p)})");
            Console.WriteLine(string.Join(", ", strPrimes));
        }

        /// <summary>
        /// Print the error messages to the console
        /// </summary>
        /// <param name="errors">The errors to print</param>
        public void ReportPalindromeErrors(IEnumerable<string> errors)
        {
            if (errors is null)
            {
                throw new OutputException("The reported errors is null - something is very wrong, try repairing the application.");
            }

            foreach (string error in errors)
            {
                Console.WriteLine(error);
            }
        }
    }
}
