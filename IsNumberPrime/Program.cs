using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNumberPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program takes a number and returns true if that number is a prime number. " +
                "A Prime number is any positive integer that is evenly divisible by only two divisors: 1 and itself. " +
                "The first 10 prime numbers are: 2, 3, 5, 7, 11, 13, 17, 19, 23 and 29.");

            var findPrime = new PrimeFiner();
            var prime_1 = findPrime.FindPrime(5);
            var prime_2 = findPrime.FindPrime(1);
            var prime_3 = findPrime.FindPrime(9);

            Console.WriteLine(prime_1);
            Console.WriteLine(prime_2);
            Console.WriteLine(prime_3);

            Console.ReadKey();
        }
    }
}
