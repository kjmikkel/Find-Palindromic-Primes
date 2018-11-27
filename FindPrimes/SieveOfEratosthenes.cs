using System.Collections.Generic;
using System.Linq;

namespace Find_Palindromic_Primes.FindPrimes
{
    /// <summary>
    /// Sieve of Eratosthenes (https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes) is a fairly simple algorithm to find all primes below a given number
    /// </summary>
    internal class SieveOfEratosthenes : IFindPrimes
    {
        public IEnumerable<int> FindPrimes(int from, int to)
        {
            if (from < 0)
            {
                // You could technically set the from be negative, but since there are no negative prime numbers, it does not make any sense
                throw new PrimeException($"The 'from' value cannot be negative: {from}");
            }
            if (to < 0)
            {
                // The from value must be non-negative, so the to value cannot be negative (as it would be smaller than the from value), and also that there are no negative prime numbers 
                throw new PrimeException($"The 'to' value cannot be negative: {to}");
            }
            if (to < from)
            {
                // In a proper interval the from value must be before the to point (startpoint must be before endpoint)
                throw new PrimeException($"The 'to' value cannot be larger than the 'from' value - from: {from}, to: {to}");
            }

            // We always start at 2 (as it is the first prime numbers)
            List<int> sieve = Enumerable.Range(2, to - 1).ToList();

            List<int> collectionToRetain = new List<int>();

            while(sieve.Count() > 0)
            {
                // The head of the list is sure to be a prime number, so pop it and remove it
                int headOfList = sieve[0];
                collectionToRetain.Add(headOfList);
                sieve.RemoveAt(0);

                // If we reach the point where the square of the head is larger than the 'to' value, then the remaining numbers must be prime
                if (headOfList * headOfList > to)
                {
                    collectionToRetain.AddRange(sieve);
                    break;
                }

                // Remove all elements that are divisible by the "head" of the list
                sieve = sieve.Where(n => n % headOfList != 0).ToList();
            }

            // Now to ensure the interval is correct
            collectionToRetain = collectionToRetain.Where(n => from <= n && n <= to).ToList();

            return collectionToRetain;
        }
    }
}
