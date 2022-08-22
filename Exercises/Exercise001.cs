using System;
using System.Collections.Generic;
using System.Linq;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return word;
            }

            return char.ToUpper(word[0]) + word.Substring(1);
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            return firstName[0] + "." + lastName[0];
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            if (originalPrice < 0)
            {
                throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            }

            if (vatRate < 0)
            {
                throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");
            }

            var addedVat = originalPrice + originalPrice * vatRate / 100;
            return Math.Round(addedVat, 2);
        }

        public string Reverse(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                return sentence;
            }
            var characters = sentence.ToCharArray();
            Array.Reverse(characters);
            return new string(characters);
        }

        public int CountLinuxUsers(List<User> users)
        {
            if (users == null)
            {
                return 0;
            }

            return users.Where(x => x.Type == "Linux")
                .GroupBy(x => x.Type)
                .Select(group => group.Count())
                .FirstOrDefault();
        }
    }
}
