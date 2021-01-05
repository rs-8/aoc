namespace AOC.Day04.Validators
{
    public interface IValidator
    {
        string FieldName { get; }
        bool Validate(string s);
    }
}