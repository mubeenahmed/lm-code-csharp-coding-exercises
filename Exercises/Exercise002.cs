using Exercises.Models;
using System;
namespace Exercises
{
    public class Exercise002
    {
        // 👉 Remember to delete all unnecessary comments (like this one) when you're done! 

        public bool IsFromManchester(Person person)
        {
            if (person == null || person.City != "Manchester")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            if (person.Age < ageLimit)
            {
                return false;
            } 
            else
            {
                return true;
            }
        }
    }
}
