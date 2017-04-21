using CandyGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGift.Candies
{
    public class Waffles: Candy, ISweetCandy, ITopping
    {
        public int Sugar { get; private set; }
        public string Topping { get; }

        public Waffles(string name, int mass, int sugar, string topping ):base (name, mass)
        {
            Sugar = sugar;
            Topping = topping;
            PropertyList = new List<object> { Name, Mass, Sugar, Topping };
        }

        
    }
}
