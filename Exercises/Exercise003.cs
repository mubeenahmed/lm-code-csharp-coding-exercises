using System;
using System.Linq;

namespace Exercises
{
    public class Exercise003
    {
        public string[] IceCreamFlavours => new string[] { 
            "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet"
        };

        public int IceCreamCode(string iceCreamFlavour) =>
            IceCreamFlavours
            .Select((value, index) => new { value, index })
            .Where(x => x.value.ToLower() == iceCreamFlavour.ToLower())
            .Select(x => x.index)
            .FirstOrDefault();
            
    }
}
