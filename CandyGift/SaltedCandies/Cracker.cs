using CandyGift.BaseCandyClasses;
using CandyGift.Interfaces;

namespace CandyGift.SaltedCandies
{
    public class Cracker : SaltedCandy, ISaltedCandy, ICandy
    {
        public int[] Size { get; }
        public Cracker(string name, int mass, int salt, int[] size) : base(name, mass, salt)
        {
            CandyType = "Cracker";
            Size = size;
        }
    }
}
