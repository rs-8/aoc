using System.Collections.Generic;

namespace AOC.Day04.Validators
{
    public class EyeColorValidator: IValidator
    {
        public string FieldName => "ecl";

        private readonly HashSet<string> eyeColors = new HashSet<string>
            {"amb", "blu", "brn", "gry", "grn", "hzl", "oth"};

        public bool Validate(string s) => eyeColors.Contains(s);
    }
}