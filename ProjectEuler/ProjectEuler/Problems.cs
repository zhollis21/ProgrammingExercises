using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler;

public class Problems
{
    /// <summary>
    /// Problem 1: Multiples of 3 and 5
    /// </summary>
    public static int Problem1()
    {
        Console.WriteLine(ProblemSummaries.Problem1);

        int sum = 0;

        for (int num = 3; num < 1000; num++)
        {
            if (num % 5 == 0 || num % 3 == 0)
            {
                sum += num;
            }
        }

        Console.WriteLine($"\nThe sum is: {sum:N0}");
        return sum;
    }

    /// <summary>
    /// Problem 2: Even Fibonacci Numbers
    /// </summary>
    public static int Problem2()
    {
        Console.WriteLine(ProblemSummaries.Problem2);

        const int maxValue = 4_000_000;
        int fibA = 1;
        int fibB = 2;
        int sum = 2;

        while (fibB < maxValue)
        {
            int newFibB = fibA + fibB;
            fibA = fibB;
            fibB = newFibB;

            if (fibB % 2 == 0)
            {
                sum += fibB;
            }
        }

        Console.WriteLine($"\nThe sum of the even values are: {sum:N0}");
        return sum;
    }

    public static int Problem3()
    {
        Console.WriteLine(ProblemSummaries.Problem3);

        const long number = 600_851_475_143;
        int maxFactor = (int)Math.Sqrt(number);

        List<int> primeNumbers = [];

        // We only loop over odd numbers which is why we have excluded 2 from the prime list
        for (int i = 3; i < maxFactor; i += 2)
        {
            // If our current number is not a factor, skip it
            if (number % i != 0)
            {
                continue;
            }

            // If our current number is evenly divisible by one of our prime numbers, skip it 
            if(primeNumbers.Any(prime => i % prime == 0))
            {
                continue;
            }

            primeNumbers.Add(i);
        }

        int largestPrimeFactor = primeNumbers.Max();

        Console.WriteLine($"\nThe largest prime factor is {largestPrimeFactor:N0}");
        return largestPrimeFactor;
    }
}
