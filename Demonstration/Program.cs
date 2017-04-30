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
            candies_creator.CreateChocolateCandy("Alenka", 25, 12, "Jam", count: 2);
            candies_creator.CreateSalmiak("Salmiak", 34, 28, count: 3);
            candies_creator.CreateWaffles("Litba", 10, 8, null, count: 1);
            #endregion

            #region Demonstration
            Gift MyGift = new Gift("MyGift", candies_creator.CandyList);
            int mass = MyGift.Mass;
            List<Candy> candy_list_sugar = MyGift.FindBySugar(10, 13);
            List<Candy> candy_list_ordered_by_name = MyGift.OrderByName();

            MyGift.ClearGift();
            #endregion

            Console.ReadKey();
        }
    }
}