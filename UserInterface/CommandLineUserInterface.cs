using CommandLine;
using Find_Palindromic_Primes.FindPrimes;
using Find_Palindromic_Primes.Interface;
using Find_Palindromic_Primes.Main;
using Find_Palindromic_Primes.Options;
using Find_Palindromic_Primes.Output;
using Find_Palindromic_Primes.Palindrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Find_Palindromic_Primes.UserInterface
{
    /// <summary>
    /// The user interface to allow the user to interact with the with the system
    /// </summary>
    internal class CommandLineUserInterface : IUserInterface
    {

        /// <summary>
        /// Send the information to the interface
        /// </summary>
        /// <param name="commands">The commands that are to be used in finding the palindromic primes</param>
        /// <param name="output">Where the result is to be reported</param>
        public void ActivateInterface(IEnumerable<string> commands, IOutput output)
        {
            Parser.Default.ParseArguments<BasicOptions>(commands)
    .WithParsed(opts => RunOptionsAndReturnExitCode(opts, output))
    .WithNotParsed((errs) => HandleParseError(errs, output));
        }

        /// <summary>
        /// The command can be parsed, and based on the values it will run
        /// </summary>
        /// <param name="options">The options that were parsed</param>
        /// <param name="output">The output object that will be used to report to the user</param>
        private void RunOptionsAndReturnExitCode(BasicOptions options, IOutput output)
        {
            if (options.Help)
            {
                PrintHelpInformation(output);
                return;
            }

            if (options.Version)
            {
                output.ReportHelpInformation("Version 1.0");
                return;
            }

            PalindromeChecker palindromeChecker;
            if (options.Palindrome == "Decimal")
            {
                palindromeChecker = new DecimalPalindromeChecker();
            }
            else if (options.Palindrome == "Binary")
            {
                palindromeChecker = new BinaryPalindromeChecker();
            }
            else
            {
                throw new PalindromeException("No valid Palindrome mode selected - you must choose either 'Decimal' or 'Binary'");
            }

            FindPalindromicPrimes fpp = new FindPalindromicPrimes();

            IFindPrimes primesFinder = new SieveOfEratosthenes();

            IEnumerable<int> primes = fpp.FindPrimes(primesFinder, palindromeChecker, options.From, options.To);

            if (options.Show)
            {
                output.ReportPalindromeData(primes, palindromeChecker);
            }
            else
            {
                output.ReportPalindromeData(primes);
            }
        }

        /// <summary>
        /// There were parse errors, and they will be reported to the user
        /// </summary>
        /// <param name="errors">The errors to be reported</param>
        /// <param name="output">The output object that will be used to report to the user</param>
        private void HandleParseError(IEnumerable<Error> errors, IOutput output)
        {
            output.ReportPalindromeErrors(errors.Select(e => e.ToString()));
        }

        /// <summary>
        /// Print the help information to the user
        /// </summary>
        /// <param name="output">The output object that will be used to report to the user</param>
        private void PrintHelpInformation(IOutput output)
        {
            string helpTemplate = "\t{0},\t{1}\t{2}";

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("The command options are:\n");
            strBuilder.Append(String.Format(helpTemplate, "-h", "help", "Display this help message\n"));
            strBuilder.Append(String.Format(helpTemplate, "-f", "from", "The lower bound of the prime list (by default this is 1)\n"));
            strBuilder.Append(String.Format(helpTemplate, "-t", "to", "The upper bound of the prime list (by default this is 1000)\n"));
            strBuilder.Append(String.Format(helpTemplate, "-p", "palindrome", "Sets which kind of palindrome check is performed - you can choose between either 'Binary' or 'Decimal' palindrome check (by default it is 'Decimal')\n"));
            strBuilder.Append(String.Format(helpTemplate, "-v", "version", "Displays version information\n"));
            strBuilder.Append(String.Format(helpTemplate, "-s", "show", "Display the non-decimal representation along with the decimal representation of the palindromic primes\n"));

            output.ReportHelpInformation(strBuilder.ToString());
        }
    }
}
