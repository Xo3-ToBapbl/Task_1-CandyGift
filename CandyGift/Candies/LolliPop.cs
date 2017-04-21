using CandyGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGift.Candies
{
    class LolliPop: Candy, ISweetCandy, ITopping 
    {
        public int Sugar { get; private set; }
        public string Topping { get; }

        public LolliPop(string name, int mass, int sugar, string topping):base (name, mass)
        {
            Sugar = sugar;
            Topping = topping;
            PropertyList = new List<object> { Name, Mass, Sugar, Topping };
        }

        public override void UpMainComponentBy(int ratio)
        {
            Sugar += ratio;
        }
        public override void DownMainComponentBy(int ratio)
        {
            if (Sugar < ratio)
            {
                Sugar -= ratio;
            }
            else
            {
                Console.WriteLine("Incorrect input. Reduction ratio is less than sugar value.");
            }
        }
    }
}
