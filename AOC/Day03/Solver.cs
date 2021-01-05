using System.Collections.Generic;
using System.Linq;
using AOC.Common;

namespace AOC.Day03
{
    public class Solver: ISolver
    {
        private readonly IList<string> input;
        
        const char tree = '#';
        
        private readonly IList<(int right, int down)> steps = new List<(int right, int down)>
        {
            (1,1),
            (3,1),
            (5,1),
            (7,1),
            (1,2)
        };

        public Solver(IEnumerable<string> input)
        {
            this.input = input.ToList();
        }

        public string GetPartOneSolution() => CountEncounteredTrees(3, 1).ToString();

        public string GetPartTwoSolution() => steps.Select(s => CountEncounteredTrees(s.right, s.down))
            .Aggregate(1UL, (acc, x) => acc * (ulong)x).ToString();

        private int CountEncounteredTrees(int stepRight, int stepDown)
        {
            var horizontalPosition = 0;
            var treesCount = 0;

            for (var row = 0; row < input.Count; row += stepDown)
            {
                horizontalPosition %= input[row].Length;
                
                if (input[row][horizontalPosition] == tree)
                {
                    treesCount++;
                }
                
                horizontalPosition += stepRight;
            }

            return treesCount;
        }
    }
}