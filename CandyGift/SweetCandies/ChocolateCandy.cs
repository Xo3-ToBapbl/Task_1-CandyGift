using CandyGift.BaseCandyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGift.SweetCandies
{
    public class ChocolateCandy : SweetCandy
    {
        public ChocolateCandy(string name, int mass, int sugar, string topping) : base(name, mass, sugar, topping)
        {
            CandyType = "ChocolateCandy";
        }
    }
}
