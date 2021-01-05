using System.Text.RegularExpressions;

namespace AOC.Day04.Validators
{
    public class HairColorValidator: IValidator
    {
        public string FieldName => "hcl";

        private Regex hairColorRegex = new Regex(@"^#[0-9a-f]{6}$");

        public bool Validate(string s) => hairColorRegex.IsMatch(s);
    }
}