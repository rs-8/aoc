using System;
using System.Collections.Generic;
using System.Linq;

namespace AOC.Day04
{
    public class Passport
    {
        private readonly List<string> requiredFields = new List<string> {
            "byr",
            "iyr",
            "eyr",
            "hgt",
            "hcl",
            "ecl",
            "pid",
        };
        protected readonly Dictionary<string, string> data = new Dictionary<string, string>();

        public void AddField(string field)
        {
            var fieldparts = field.Split(':');
            if (fieldparts.Length != 2)
            {
                throw new ArgumentException($"Value of field is not acceptable. Field: {field}");
            }

            var fieldname = fieldparts[0].Trim();
            var fieldvalue = fieldparts[1].Trim();
            data.TryAdd(fieldname, fieldvalue);
        }

        public virtual bool IsValid() => requiredFields.All(rqf => data.ContainsKey(rqf));
    }
}