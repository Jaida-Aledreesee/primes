using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumbers
{
    class Primes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it is a prime or not: ");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            checknumbers check = new checknumbers();
            if (check.checkNumber(number))
            {
                Console.WriteLine("It is prime");
            }
            else
            {
                Console.WriteLine("It is not prime");
            }
            Console.ReadKey();
        }


    }
}








