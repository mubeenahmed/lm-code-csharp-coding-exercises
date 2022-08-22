using System;
using System.Text.RegularExpressions;

namespace Exercises
{
    public class Exercise005
    {

        public bool IsPangram(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            input = filterInput(input);
            var english26Alphabets = new int[26];

            for (int i = 0; i < input.Length; i++)
            {
                int ascii = input[i];
                var index = ascii - 97;
                english26Alphabets[index] -= 1;
            }

            foreach (var alphbates in english26Alphabets)
            {
                if (alphbates == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private string filterInput(string input)
        {
            Regex reg = new Regex("[ *'\",_&#^@0-9]");
            var result = reg.Replace(input, string.Empty);
            return result.ToLower();
        }
    }
}
