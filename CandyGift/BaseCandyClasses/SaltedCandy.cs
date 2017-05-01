using CandyGift.Interfaces;
using System;
using System.Collections.Generic;

namespace CandyGift.BaseCandyClasses
{
    public abstract class SaltedCandy : Candy, ICandy, ISaltedCandy
    {
        public int Salt { get; private set; }

        public SaltedCandy(string name, int mass, int salt) : base(name, mass)
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
            if (ratio < Salt)
            {
                Salt -= ratio;
            }
            else
            {
                throw new Exception("Incorrect input. Reduction ratio is less than sugar value.");
            }
        }
    }
}
