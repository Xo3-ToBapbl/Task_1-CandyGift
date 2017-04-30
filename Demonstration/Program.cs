using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyGift.SweetCandies;
using CandyGift.SaltedCandies;
using CandyGift.BaseCandyClasses;
using System.Xml.Linq;
using System.Web.Script.Serialization;
using CandyGift.CandiesCreator;
using CandyGift.Gifts;

namespace Demonstration
{
    class Program
    {  
        static void Main(string[] args)
        {
            #region Candies Creator
            CandiesCreator candies_creator = new CandiesCreator();
            candies_creator.CreateChocolateCandy("Alenka", 25, 12, "Jam", count: 5);
            candies_creator.CreateSalmiak("Salmiak", 34, 28, count: 3);
            candies_creator.CreateWaffles("Vitba", 10, 8, null, count: 1);

            List<Candy> candy_list = candies_creator.CandyList;
            candy_list.RemoveAll(x=>x.Name== "Salmiak");
            #endregion

            #region Demonstration
            Gift MyGift = new Gift("MyGift", candies_creator.CandyList);
            int mass = MyGift.Mass;

            Gift MyGift2 = new Gift("MtGift2");
            int mass2 = MyGift2.Mass;
            //MyGift.GetMass();
            //MyGift.FindBySugar(25, 26);
            //MyGift.OrderByName();
            //MyGift.OrderByMass();
            #endregion

            Console.ReadKey();
        }
    }
}