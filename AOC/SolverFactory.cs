using System;
using AOC.Common;
using AOC.Day02;
using AOC.Day05;

namespace AOC
{
    public class SolverFactory
    {
        public static ISolver GetSolver(int day) => day switch
        {
            1 => new Day01.Solver(new Input<int>("01", s => int.Parse(s))),
            2 => new Day02.Solver(new Input<Password>("02", s => Password.Parse(s))),
            3 => new Day03.Solver(new Input<string>("03", s => s)),
            4 => new Day04.Solver(new Input<string>("04", s => s)),
            5 => new Day05.Solver(new Input<BoardingPass>("05", s => new BoardingPass(s))),
            _ => throw new Exception()
        };
    }
}