using CandyGift.BaseCandyClasses;
using CandyGift.Interfaces;

namespace CandyGift.SweetCandies
{
    public class ChocolateCandy : SweetCandy, ISweetCandy, ICandy
    {
        public ChocolateCandy(string name, int mass, int sugar, string topping) : base(name, mass, sugar, topping)
        {
            CandyType = "ChocolateCandy";
        }
    }
}
