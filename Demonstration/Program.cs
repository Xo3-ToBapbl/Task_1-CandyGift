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

            Dictionary<Candy, int> Candies = new Dictionary<Candy, int>()
            {
                {HollandWaffles, 5},
                {Alenka, 3},
                {Lolli, 6},

                {Cracen, 7},
                {Lakrica, 5}
            };
            #endregion
            Gift MyGift = new Gift("MyGift", Candies);
            MyGift.FindBySugar(17, 26);

            Console.ReadKey();
        }
    }
}
