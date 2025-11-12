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
                return [ problem ];
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
    private static HashSet<int> PrimeNumbers { get; set; } = [ 2, 3 ];
    private static int _maxPrimeChecked = 3;

    public static bool IsPrimeNumber(int number)
    {
        // If we have already calculated the prime numbers up to this number
        // then we don't need to calculate anything we can just check our list
        if (number <= _maxPrimeChecked)
        {
            return PrimeNumbers.Contains(number);
        }

        // Otherwise, we will keep calculating prime numbers
        // until we find one equal to or greater than our number
        for (int i = _maxPrimeChecked + 2; _maxPrimeChecked < number; i += 2)
        {
            if (PrimeNumbers.Any(prime => i % prime == 0))
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

    /// <summary>
    /// Gets the Nth position in the prime numbers list
    /// </summary>
    /// <param name="nth">This starts with 1 instead of 0</param>
    public static int GetNthPrimeNumber(int nth)
    {
        int stepSize = 10_000;
        int primeCheckStep = _maxPrimeChecked + stepSize;
        while (PrimeNumbers.Count < nth)
        {
            IsPrimeNumber(primeCheckStep);
            primeCheckStep += stepSize;
        }

        return PrimeNumbers.Order().ElementAt(nth - 1);
    }
}
