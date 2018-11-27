using Find_Palindromic_Primes.Output;
using Find_Palindromic_Primes.UserInterface;
using System;

namespace Find_Palindromic_Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IOutput consolePrinter = new ConsoleOutputPrinter();
                CommandLineUserInterface commandLine = new CommandLineUserInterface();

                commandLine.ActivateInterface(args, consolePrinter);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
