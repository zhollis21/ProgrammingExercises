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
            if (primeNumbers.Any(prime => i % prime == 0))
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

        for (int dividend = 20; true; dividend += 20)
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

    public static long Problem7()
    {
        Console.WriteLine(ProblemSummaries.Problem7);

        long answer = Helpers.GetNthPrimeNumber(10_001);

        Console.WriteLine($"\nThe number is {answer:N0}");
        return answer;
    }

    public static long Problem8()
    {
        Console.WriteLine(ProblemSummaries.Problem8);

        string bigNumber = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";

        long maxProduct = 0;
        for (int i = 0; i < bigNumber.Length - 13; i++)
        {
            long product = 1;

            for (int j = 0; j < 13; j++)
            {
                // A bit weird, but the fastest way to turn this char into an int
                product *= bigNumber[i + j] - '0';
            }

            if (product >= maxProduct)
            {
                maxProduct = product;
            }
        }

        Console.WriteLine($"\nThe max product is {maxProduct:N0}");
        return maxProduct;
    }

    public static int Problem9()
    {
        Console.WriteLine(ProblemSummaries.Problem9);

        const int desiredSum = 1_000;

        for (int a = 1; a < desiredSum; a++)
        {
            for (int b = a; b < desiredSum; b++)
            {
                int c = desiredSum - (a + b);

                if ((a * a) + (b * b) == c * c)
                {
                    int product = a * b * c;

                    Console.WriteLine($"\nThe product of abc is {product:N0}");
                    return product;
                }
            }
        }

        Console.WriteLine($"\nNo answer was found...");
        return 0;
    }

    public static long Problem10()
    {
        Console.WriteLine(ProblemSummaries.Problem10);

        const int maxPrimeValue = 2_000_000;

        var sum = Helpers.GetPrimeNumbersUpTo(maxPrimeValue).Sum();

        Console.WriteLine($"\nThe sum is {sum:N0}");
        return sum;
    }
}