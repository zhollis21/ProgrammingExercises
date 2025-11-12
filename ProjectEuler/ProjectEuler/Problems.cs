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

    public static int Problem4()
    {
        Console.WriteLine(ProblemSummaries.Problem4);

        var largestPalindrome = 0;

        for (int i = 999; i > 99; i--)
        {
            for (int j = 999; j > 99; j--)
            {
                int product = i * j;

                // Don't even bother checking if it's a palendrome if it's not larger
                if (product < largestPalindrome)
                {
                    continue;
                }

                if (Helpers.IsPalindrome(product.ToString()))
                {
                    largestPalindrome = product;
                }
            }
        }

        Console.WriteLine($"\nThe largest palindrome is {largestPalindrome:N0}");
        return largestPalindrome;
    }

    public static int Problem5()
    {
        Console.WriteLine(ProblemSummaries.Problem5);

        for (int dividend = 20; true; dividend++)
        {
            for (int divisor = 19; divisor > 1; divisor--)
            {
                if (dividend % divisor != 0)
                {
                    break;
                }

                if (divisor == 2)
                {
                    Console.WriteLine($"\nThe smallest multiple is {dividend:N0}");
                    return dividend;
                }
            }
        }
    }

    public static int Problem6()
    {
        Console.WriteLine(ProblemSummaries.Problem6);

        int sumOfSquares = 0;
        int squareOfSum = 0;

        for (int i = 1; i <= 100; i++)
        {
            sumOfSquares += i * i;
            squareOfSum += i;
        }

        // For squareOfSum, we use the loop to add up all the numbers and then multiply it by itself for the square
        squareOfSum *= squareOfSum;

        int difference = squareOfSum - sumOfSquares;

        Console.WriteLine($"\nThe difference is {difference:N0}");
        return difference;
    }

    public static int Problem7()
    {
        Console.WriteLine(ProblemSummaries.Problem7);

        return 0;
    }

    public static long Problem8()
    {
        Console.WriteLine(ProblemSummaries.Problem8);

        return 0;
    }

    public static int Problem9()
    {
        Console.WriteLine(ProblemSummaries.Problem9);

        return 0;
    }

    public static long Problem10()
    {
        Console.WriteLine(ProblemSummaries.Problem10);

        return 0;
    }
}
