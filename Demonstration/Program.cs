using System;
using System.Collections.Generic;
using CandyGift.SweetCandies;
using CandyGift.BaseCandyClasses;
using CandyGift.CandiesCreator;
using CandyGift.Gifts;

namespace Demonstration
{
    class Program
    {  
        static void Main(string[] args)
        {
            int mass;
            #region Candies Creator
            CandiesCreator candies_creator = new CandiesCreator();
            candies_creator.CreateChocolateCandy("Alenka", 25, 12, "Jam", count: 2);
            candies_creator.CreateSalmiak("Salmiak", 34, 28, count: 3);
            candies_creator.CreateCracker("Craken", 20, 15, new int[] { 5, 5 }, count: 5);
            candies_creator.CreateWaffles("Vitba", 10, 8, null, true, count: 1);
            candies_creator.CreateLolliPop("Sosulka", 3, 12, "pomade","circle",count: 11);
            #endregion

            #region Some Candies
            LolliPop Rocks = new LolliPop("Rocks", 5, 10, null, "square");
            Waffles Twix = new Waffles("Twix", 25, 20, "nuts", false);
            #endregion

            #region Gift
            Gift MyGift = new Gift("MyGift", candies_creator.CandyList);
            mass = MyGift.Mass;
            MyGift.AddCandy(Rocks);
            MyGift.AddCandy(Twix);
            mass = MyGift.Mass;
            List<Candy> candy_list_sugar = MyGift.FindBySugar(10, 13);     // thin place
            List<Candy> candy_list_ordered_by_name = MyGift.OrderByName(); // thin place
            List<Candy> candy_list_ordered_by_mass = MyGift.OrderByMass(); // thin place

            MyGift.RemoveAllCandiesByName("Sosulka"); // Reference to 'Candy' objects are exist in sorted 'List' objects,                               
            MyGift.ClearGift();                       // but 'Gift' may be clear or modified, is it true?
            #endregion

            Console.ReadKey();
        }
    }
}