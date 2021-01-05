namespace AOC.Day04.Validators
{
    public class ExpirationYearValidator: YearValidator, IValidator
    {
        public string FieldName => "eyr";
        
        public ExpirationYearValidator()
        {
            fromYear = 2020;
            toYear = 2030;
        }
    }
}