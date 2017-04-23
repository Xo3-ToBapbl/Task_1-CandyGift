using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyGift.SweetCandies;
using CandyGift.SaltedCandies;
using CandyGift.BaseCandyClasses;
using CandyGift.Gifts;

namespace Demonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Data
            Waffles HollandWaffles = new Waffles("Holland Waffles", 50, 25, "Jam");
            ChocolateCandy Alenka = new ChocolateCandy("Alenka", 35, 18, "Jam");
            LolliPop Lolli = new LolliPop("Lolli", 5, 11, "Cherry");

            Cracker Cracen = new Cracker("Cracen", 10, 8);
            Salmiak Lakrica = new Salmiak("Lakrica", 15, 12);

            Dictionary<int, Candy> Candies = new Dictionary<int, Candy>()
            {
                {5, HollandWaffles },
                {3, Alenka },
                {6, Lolli },

                {7, Cracen },
                {5, Lakrica}
            };
            #endregion
            Gift MyGift = new Gift("MyGift", Candies);
            Console.ReadKey();
        }
    }
}
