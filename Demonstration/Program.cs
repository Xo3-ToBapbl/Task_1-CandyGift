using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyGift.SweetCandies;
using CandyGift.SaltedCandies;
using CandyGift.BaseCandyClasses;
using CandyGift.Gifts;
using System.Xml.Linq;
using System.Web.Script.Serialization;
using CandyGift.Static;

namespace Demonstration
{
    class Program
    {  
        static void Main(string[] args)
        {
            List<Candy> candies_list = StaticFunctions.LoadXML();
            Dictionary<Candy, int> candies_dict = StaticFunctions.CreateGiftDict(candies_list);

            #region Demonstration
            Gift MyGift = new Gift("MyGift", candies_dict);
            MyGift.GetMass();
            MyGift.FindBySugar(25, 26);
            MyGift.OrderByName();
            MyGift.OrderByMass();
            #endregion

            Console.ReadKey();
        }
    }
}