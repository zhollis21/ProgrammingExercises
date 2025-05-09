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
}
