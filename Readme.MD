# Find Palindromic Primes
A program to find Palindromic primes in both base 10 and base 2 (decimal and binary).

## Palindromic primes
A palindromic prime is a prime number, that in the chosen base is a palindromic number (i.e. is a number that remains the same when you reverse its digits).

A prime that is palindromic in one base is not necesarry palindromic in another - for instance all the one digit prime numbers are palindromic in base 10, but not in base 2 (in base 10 the palindromic primes under ten are 2, 3, 5 and 7, but in base 2 they are only 3 (11), 5 (101), and 7 (111)).

## Console commands
To interact with the Palindromic Prime Checker I have included a Command Line Interface (CLI) - there are the following options:

"-h": Display the help
"-f": The lower bound of the prime list (must be non-negative integer, cannot be bigger than the upper bound). By default it is 1.
"-t": The upper bound of the prime list (must be non-negative integer, cannot be smaller than the lower bound). By default it is 1000.
"-p": The type of the palindrome base - its argument must be a string and either "Decimal" or "Binary"
"-v": Displays the version of the application.
"-s": Display the primes the both the base of the palindromic property it was checked against, as well as in base 10 - so for instance for a list of the primes from 1 to 10 in binary would display the primes as "11 (3), 101 (5), 111 (7)"