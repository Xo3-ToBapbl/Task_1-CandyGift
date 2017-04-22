using CandyGift.BaseCandyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGift.SaltedCandies
{
    public class Salmiak : SaltedCandy
    {
        public Salmiak(string name, int mass, int salt) : base(name, mass, salt)
        {
            CandyType = "Salmiak";
        }
    }
}
