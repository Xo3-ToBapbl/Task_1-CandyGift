using CandyGift.BaseCandyClasses;
using CandyGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGift.SweetCandies
{
    public class Waffles: SweetCandy
    { 
        public Waffles(string name, int mass, int sugar, string topping ):base (name, mass, sugar, topping)
        {
        } 
    }
}
