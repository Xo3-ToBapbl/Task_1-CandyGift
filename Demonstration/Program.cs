using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyGift.SweetCandies;
using CandyGift.SaltedCandies;
using CandyGift.BaseCandyClasses;

namespace Demonstration
{
    class Program
    {
        static void LINQ(Dictionary<int, Candy> Dict)
        {
            var container = from value in Dict.Values
                            from key in Dict.Keys
                            select key * value.Mass;


            foreach (var item in container)
                Console.WriteLine(item);
        }

        static void Main(string[] args)
        {
            #region Data
            Waffles HollandWaffles = new Waffles("Holland Waffles", 2, 5, "Jam");
            LolliPop Lolli = new LolliPop("Lolli", 1, 11, "Cherry");
            Cracker Cracen = new Cracker("Cracen", 1, 8);

            Dictionary<int, Candy> CandiesDict = new Dictionary<int, Candy>()
            {
                {5, HollandWaffles },
                {6, Lolli },
                {7, Cracen }
            };
            #endregion
            LINQ(CandiesDict);
            Console.ReadKey();
        }
    }
}
