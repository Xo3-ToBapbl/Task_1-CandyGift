using CandyGift.BaseCandyClasses;
using CandyGift.Interfaces;

namespace CandyGift.SaltedCandies
{
    public class Salmiak : SaltedCandy, ISaltedCandy, ICandy
    {
        public Salmiak(string name, int mass, int salt) : base(name, mass, salt)
        {
            CandyType = "Salmiak";
        }
    }
}
