using ProjectEuler;
using System.Diagnostics;

Console.WriteLine("Hello. Welcome to the Project Euler solver.\n");

while (true)
{
    var problem = Helpers.GetProblem();

    var stopwatch = Stopwatch.StartNew();

    var _ = problem();

    stopwatch.Stop();
    Console.WriteLine($"Execution Time: {stopwatch.Elapsed.TotalSeconds:F3} seconds\n");
}
