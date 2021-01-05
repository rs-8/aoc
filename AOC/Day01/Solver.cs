using AOC.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Day01
{
    public class Solver: ISolver
    {
        private readonly HashSet<int> numbers = new HashSet<int>();
        
        public Solver(IEnumerable<int> input)
        {
            this.numbers = input.ToHashSet();
        }
        
        public string GetPartOneSolution()
        {
            var target = 2020;

            foreach (var num in numbers)
            {
                if (numbers.Contains(target - num))
                {
                    return (num * (target - num)).ToString();
                }
            }
            
            return "No solution!";
        }

        public string GetPartTwoSolution()
        {
            var target = 2020;
            
            foreach (var num1 in numbers)
            {
                foreach (var num2 in numbers)
                {
                    if (numbers.Contains(target - num1 - num2))
                    {
                        return (num1 * num2 * (target - num1 - num2)).ToString();
                    }
                }
            }
            
            return "No solution!";
        }
    }
}