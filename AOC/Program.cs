using System;
using System.Diagnostics;

namespace AOC
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatchAll = new Stopwatch();
            stopwatchAll.Start();
            for (int dayNumber = 6; dayNumber <= 6; dayNumber++)
            {
                var solver = SolverFactory.GetSolver(dayNumber);

                var stopwatch = new Stopwatch();
                stopwatch.Start();
                var partOneSolution = solver.GetPartOneSolution();
                stopwatch.Stop();
                var time1 = stopwatch.Elapsed.TotalMilliseconds;
                Console.WriteLine($"Day {dayNumber} part one solution: {partOneSolution} solved in {time1} ms");
                stopwatch.Reset(); 

                stopwatch.Start();
                var partTwoSolution = solver.GetPartTwoSolution();
                stopwatch.Stop();
                var time2 = stopwatch.Elapsed.TotalMilliseconds;
                Console.WriteLine($"Day {dayNumber} part two solution: {partTwoSolution} solved in {time2} ms");
                stopwatch.Reset();
            }
            stopwatchAll.Stop();
            Console.WriteLine($"All daily puzzle solved in {stopwatchAll.Elapsed.TotalSeconds} s");
        }
    }
}