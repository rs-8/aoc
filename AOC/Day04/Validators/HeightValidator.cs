using System;
using System.Collections.Generic;
using System.Linq;

namespace AOC.Day04.Validators
{
    public class HeightValidator: IValidator
    {
        public string FieldName => "hgt";

        private readonly HashSet<string> heightDimensions = new HashSet<string> {"cm", "in"};
        
        public bool Validate(string s)
        {
            var dimension = s[^2..];
            
            if (heightDimensions.All(hdm => hdm != dimension)) return false;

            var stringOfDigits = new string(s.Where(ch => char.IsDigit(ch)).ToArray());

            if (!int.TryParse(stringOfDigits, out int value))
            {
                throw new Exception($"Value is not an integer! {stringOfDigits}");
            }

            return dimension switch
            {
                "cm" => 150 <= value && value <= 193,
                "in" => 59 <= value && value <= 76,
                _ => false,
            };
        }
    }
}