using CandyGift.BaseCandyClasses;
using CandyGift.Interfaces;

namespace CandyGift.SweetCandies
{
    public class LolliPop : SweetCandy, ISweetCandy, ICandy
    {
        public string Form { get; }
        public LolliPop(string name, int mass, int sugar, string topping, string form) : base(name, mass, sugar, topping)
        {
            CandyType = "LolliPop";
            Form = form;
        }
    }
}
