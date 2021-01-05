using System.Collections.Generic;
using System.Linq;
using AOC.Common;

namespace AOC.Day02
{
    public class Solver: ISolver
    {
        private readonly IEnumerable<Password> input;
        
        public Solver(IEnumerable<Password> input)
        {
            this.input = input;
        }
        
        public string GetPartOneSolution()
        {
            return input.Count(p => p.isValidRental).ToString();
        }

        public string GetPartTwoSolution()
        {
            return input.Count(p => p.isValidToboggan).ToString();
        }
    }
}