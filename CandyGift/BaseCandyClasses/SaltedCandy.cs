using CandyGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGift.BaseCandyClasses
{
    public class SaltedCandy : Candy, ISaltedCandy
    {
        public int Salt { get; private set; }

        protected SaltedCandy(string name, int mass, int salt) : base(name, mass)
        {
            Salt = salt;
            PropertyList = new List<object> { Name, Mass, Salt};
        }

        public override void UpMainComponentBy(int ratio)
        {
            Salt += ratio;
        }
        public override void DownMainComponentBy(int ratio)
        {
            if (Salt < ratio)
            {
                Salt -= ratio;
            }
            else
            {
                Console.WriteLine("Incorrect input. Reduction ratio is less than sugar value.");
            }
        }
    }
}
