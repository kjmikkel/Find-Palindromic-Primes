using Find_Palindromic_Primes.Output;
using System.Collections.Generic;

namespace Find_Palindromic_Primes.Interface
{
    /// <summary>
    /// The user interface to allow the user to interact with the with the system
    /// </summary>
    public interface IUserInterface
    {
        /// <summary>
        /// Send the information to the interface
        /// </summary>
        /// <param name="commands">The commands that are to be used in finding the palindromic primes</param>
        /// <param name="output">Where the result is to be reported</param>
        void ActivateInterface(IEnumerable<string> commands, IOutput output);
    }
}
