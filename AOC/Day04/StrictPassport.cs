using System.Collections.Generic;
using AOC.Day04.Validators;

namespace AOC.Day04
{
    public class StrictPassport: Passport
    {
        private readonly List<IValidator> validators = new List<IValidator>
        {
            new BirthYearValidator(),
            new ExpirationYearValidator(),
            new EyeColorValidator(),
            new HairColorValidator(),
            new HeightValidator(),
            new IssueYearValidator(),
            new PassportIDValidator(),
        };

        public override bool IsValid()
        {
            var isValid = base.IsValid();

            foreach (var validator in validators)
            {
                if (!isValid) break;

                if (data.TryGetValue(validator.FieldName, out string fieldValue))
                {
                    isValid &= validator.Validate(fieldValue);
                }
                else
                {
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}