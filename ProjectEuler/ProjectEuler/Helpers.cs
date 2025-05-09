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
    };

    public static Func<object> GetProblem()
    {
        while (true)
        {
            Console.Write("\nPlease enter a problem number to solve: ");

            var input = Console.ReadLine();

            if (!int.TryParse(input, out int problemNumber))
            {
                Console.WriteLine($"`{input}` is not a valid integer, try again.");
                continue;
            }

            if (_problemMap.TryGetValue(problemNumber, out var problem))
            {
                return problem;
            }

            Console.WriteLine($"No solution has been created yet for problem {problemNumber}.");

            var problemList = string.Join(", ", _problemMap.Keys);
            Console.WriteLine($"\nThe problems that have solutions are: {problemList}");
        }
    }
}
