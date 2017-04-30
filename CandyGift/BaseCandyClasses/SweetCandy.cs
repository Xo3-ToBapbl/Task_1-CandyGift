using CandyGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGift.BaseCandyClasses
{
    public class SweetCandy: Candy, ICandy, ISweetCandy, ITopping
    {
        public int Sugar { get; private set; }
        public string Topping { get; private set; }

        public SweetCandy(string name, int mass, int sugar, string topping):base (name, mass)
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
                throw new Exception("Incorrect input. Reduction ratio is less than sugar value.");
            }
        }
    }
}
