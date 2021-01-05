using System;
using System.Collections.Generic;
using AOC.Common;

namespace AOC.Day04
{
    public class Solver: ISolver
    {
        private readonly IEnumerable<string> input;

        public Solver(IEnumerable<string> input)
        {
            this.input = input;
        }
        
        public string GetPartOneSolution()
        {
            return GetValidPassportsCount(() => new Passport()).ToString();
        }

        public string GetPartTwoSolution()
        {
            return GetValidPassportsCount(() => new StrictPassport()).ToString();
        }

        public int GetValidPassportsCount(Func<Passport> createPassport)
        {
            var validPassportCount = 0;
            var passport = createPassport();

            foreach (var line in input)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    if (passport.IsValid())
                    {
                        validPassportCount++;
                    }

                    passport = createPassport();
                }
                else
                {
                    foreach (var field in line.Split(' '))
                    {
                        passport.AddField(field);
                    }
                }
            }
            
            if (passport.IsValid())
            {
                validPassportCount++;
            }

            return validPassportCount;
        }
    }
}