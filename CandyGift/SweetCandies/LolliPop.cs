using CandyGift.BaseCandyClasses;
using CandyGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGift.SweetCandies
{
    public class LolliPop : SweetCandy
    {
        public LolliPop(string name, int mass, int sugar, string topping) : base(name, mass, sugar, topping)
        {
            CandyType = "LolliPop";
        }
    }
}
