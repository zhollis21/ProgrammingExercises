using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler;

public static class Helpers
{
    private static readonly Dictionary<int, Func<object>> _problemMap = new()
    {
        { 1, () => Problems.Problem1() },
        { 2, () => Problems.Problem2() },
        { 3, () => Problems.Problem3() },
        { 4, () => Problems.Problem4() },
        { 5, () => Problems.Problem5() },
        { 6, () => Problems.Problem6() },
        { 7, () => Problems.Problem7() },
        { 8, () => Problems.Problem8() },
        { 9, () => Problems.Problem9() },
        { 10, () => Problems.Problem10() },
    };

    public static List<Func<object>> GetProblems()
    {
        while (true)
        {
            Console.Write("\nPlease enter a problem number to solve or enter 0 to run all: ");

            var input = Console.ReadLine();

            if (!int.TryParse(input, out int problemNumber))
            {
                Console.WriteLine($"`{input}` is not a valid integer, try again.");
                continue;
            }

            if (problemNumber == 0)
            {
                return _problemMap.Values.ToList();
            }

            if (_problemMap.TryGetValue(problemNumber, out var problem))
            {
                return [problem];
            }

            Console.WriteLine($"No solution has been created yet for problem {problemNumber}.");

            var problemList = string.Join(", ", _problemMap.Keys);
            Console.WriteLine($"\nThe problems that have solutions are: {problemList}");
        }
    }

    public static bool IsPalindrome(string text)
    {
        int frontIndex = 0;
        int backIndex = text.Length - 1;

        while (frontIndex < backIndex)
        {
            if (text[frontIndex] != text[backIndex])
            {
                return false;
            }

            frontIndex++;
            backIndex--;
        }

        return true;
    }

    // These are reused between problems so we only have to calculate them once
    /// <summary>
    /// Gets the current set of prime numbers that have computed.
    /// Use <see cref="IsPrimeNumber" /> and <see cref="GetNthPrimeNumber" /> to calculate more prime numbers.
    /// </summary>
    /// <remarks>
    /// The set is initialized with the values 2 and 3 and may be extended as additional primes are
    /// calculated. The collection is shared and reused to improve performance when prime numbers are needed in multiple
    /// operations.
    /// </remarks>
    private static List<long> PrimeNumbers { get; set; } = [2, 3];
    private static long _maxPrimeChecked = 3;


    public static bool IsPrimeNumber(long number)
    {
        // If we have already calculated the prime numbers up to this number
        // then we don't need to calculate anything we can just check our list
        if (number <= _maxPrimeChecked)
        {
            return PrimeNumbers.Contains(number);
        }

        // Otherwise, we will keep calculating prime numbers
        // until we find one equal to or greater than our number
        for (long i = _maxPrimeChecked + 2; _maxPrimeChecked < number; i += 2)
        {
            if (!IsPrime(i))
            {
                continue;
            }

            PrimeNumbers.Add(i);
            _maxPrimeChecked = i;

            if (i == number)
            {
                return true;
            }
        }

        return false;
    }

    private static bool IsPrime(long number)
    {
        foreach (long prime in PrimeNumbers)
        {
            // If prime is higher than the square root, no point in checking
            if (prime * prime > number)
            {
                return true;
            }

            if (number % prime == 0)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Gets the Nth position in the prime numbers list
    /// </summary>
    /// <param name="nth">This starts with 1 instead of 0</param>
    public static long GetNthPrimeNumber(int nth)
    {
        int stepSize = 10_000;
        long primeCheckStep = _maxPrimeChecked + stepSize;
        while (PrimeNumbers.Count < nth)
        {
            IsPrimeNumber(primeCheckStep);
            primeCheckStep += stepSize;
        }

        return PrimeNumbers[nth - 1];
    }

    public static IEnumerable<long> GetPrimeNumbersUpTo(long number)
    {
        if (_maxPrimeChecked < number)
        {
            IsPrimeNumber(number); // This will add n+1 primes that we need
        }

        return PrimeNumbers.Where(p => p < number);
    }
}