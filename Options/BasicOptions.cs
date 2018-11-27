using CommandLine;

namespace Find_Palindromic_Primes.Options
{
    /// <summary>
    /// The options used for the commandline interface
    /// </summary>
    internal class BasicOptions
    {
        [Option('h', "help", Required = false, HelpText = "Show help text" )]
        public bool Help { get; set; }

        [Option('f', "from", Default = 1, Required = false, HelpText = "The lower bound of the prime list")]
        public int From { get; set; }

        [Option('t', "to", Default = 1000, Required = false, HelpText = "The upper bound of the prime list")]
        public int To { get; set; }

        [Option('p', "palindrome", Required = true, HelpText = "Set the type of Palindrome checker - either Decimal (default) or Binary")]
        public string Palindrome { get; set; }

        [Option('v', "version", Required = false, HelpText = "Display the version information")]
        public bool Version { get; set; }

        [Option('s', "show", Required = false, Default = false, HelpText = "Display the prime in the base its palindromic property was checked against alongside the prime in the base 10")]
        public bool Show { get; set; }
    }
}
