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

        Console.WriteLine($"\nThe sum is: {sum}");
        return sum;
    }
}
