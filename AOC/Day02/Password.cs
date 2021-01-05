using System;
using System.Linq;
using AOC.Common;

namespace AOC.Day02
{
    public class Password
    {
        private readonly int firstParam;
        private readonly int secondParam;
        private readonly char character;
        private readonly string word;

        public static Password Parse(string arg)
        {
            var parts = arg.Split(new char[] {' ', ':', '-'}, StringSplitOptions.RemoveEmptyEntries);
            var firstParam = int.Parse(parts[0]);
            var secondParam = int.Parse(parts[1]);
            var character = parts[2][0];
            var word = parts[3];
            return new Password(firstParam, secondParam, character, word);
        }

        public Password(int firstParam, int secondParam, char character, string word)
        {
            this.firstParam = firstParam;
            this.secondParam = secondParam;
            this.character = character;
            this.word = word;
        }

        public bool isValidRental => word.Count(c => c == character).IsBetween(firstParam, secondParam);

        public bool isValidToboggan
        {
            get
            {
                var charAtFirstParam = word[firstParam - 1];
                var charAtSecondParam = word[secondParam - 1];
                return (charAtFirstParam == character && charAtSecondParam != character) || (charAtSecondParam == character && charAtFirstParam != character);
            }
        }
    }
}