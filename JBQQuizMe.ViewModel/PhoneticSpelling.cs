using System;

namespace JBQQuizMe.ViewModel
{
    public static class PhoneticSpelling
    {
        public static readonly Dictionary<string, string> Map = new Dictionary<string, string>()
        {
            { "Melchizedek", "melkeezuhdek" },
            { "Potiphar", "paatuhfr" },
            { "Hagar", "haygaar" },
            { "Joab", "jowab" },
            { "Job", "jowb" },
            { "Elisha", "uhlaishuh" },
        };


        public static string ReplaceWithPhoneticSpellings(this string value)
        {
            var retVal = value;

            foreach (var item in Map)
            {
                retVal = retVal.Replace(item.Key, item.Value, StringComparison.CurrentCultureIgnoreCase);
            }

            return retVal;
        }
    }
}
