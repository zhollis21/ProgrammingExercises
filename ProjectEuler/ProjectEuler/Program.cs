using ProjectEuler;
using System.Diagnostics;

Console.WriteLine("Hello. Welcome to the Project Euler solver.\n");

while (true)
{
    var problems = Helpers.GetProblems();

    var stopwatch = Stopwatch.StartNew();

    foreach (var problem in problems)
    {
        var _ = problem();
    }

    stopwatch.Stop();
    Console.WriteLine($"Execution Time: {stopwatch.Elapsed.TotalSeconds:F4} seconds\n");
}
