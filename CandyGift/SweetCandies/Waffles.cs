using CandyGift.BaseCandyClasses;
using CandyGift.Interfaces;

namespace CandyGift.SweetCandies
{
    public class Waffles: SweetCandy, ISweetCandy, ICandy
    {
        public bool Stratification { get; }
        public Waffles(string name, int mass, int sugar, string topping, bool stratification ):
            base (name, mass, sugar, topping)
        {
            CandyType = "Waffle";
            Stratification = stratification;
        } 
    }
}
