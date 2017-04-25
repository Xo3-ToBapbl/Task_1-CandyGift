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

namespace Demonstration
{
    class Program
    {
        static void CreateXML(ICollection<Candy> candies)
        {
            XDocument xdoc = new XDocument();
            XElement xroot = new XElement("Candies");
            #region Main cycle
            foreach (Candy candy in candies)
            {
                if (candy is SweetCandy)
                {
                    SweetCandy sweet_candy = (SweetCandy)candy;
                    XElement candy_type = new XElement("CandyType");
                    XAttribute candy_type_attr = new XAttribute("type", sweet_candy.CandyType);

                    XElement name = new XElement("Name", sweet_candy.Name);
                    XElement mass = new XElement("Mass", sweet_candy.Mass);
                    XElement sugar = new XElement("Sugar", sweet_candy.Sugar);
                    XElement topping = new XElement("Topping", sweet_candy.Topping);

                    candy_type.Add(candy_type_attr, name, mass, sugar, topping);
                    xroot.Add(candy_type);
                }
                if (candy is SaltedCandy)
                {
                    SaltedCandy salted_candy = (SaltedCandy)candy;
                    XElement candy_type = new XElement("CandyType");
                    XAttribute candy_type_attr = new XAttribute("type", salted_candy.CandyType);

                    XElement name = new XElement("Name", salted_candy.Name);
                    XElement mass = new XElement("Mass", salted_candy.Mass);
                    XElement salt = new XElement("Salt", salted_candy.Salt);

                    candy_type.Add(candy_type_attr, name, mass, salt);
                    xroot.Add(candy_type);
                }
            }
            #endregion
            xdoc.Add(xroot);
            xdoc.Save("CandiesData.xml");
         }
        static void Main(string[] args)
        {
            #region Data
            Waffles HollandWaffles = new Waffles("Holland Waffle", 50, 25, "Jam");
            ChocolateCandy Alenka = new ChocolateCandy("Alenka", 35, 18, "Jam");
            LolliPop Lolli = new LolliPop("Lolli", 5, 11, "Cherry");
            Cracker Cracen = new Cracker("Cracen", 10, 8);
            Salmiak Lakrica = new Salmiak("Lakrica", 15, 12);

            List<Candy> candies = new List<Candy>()
            {
                HollandWaffles,
                Alenka,
                Lolli,
                Cracen,
                Lakrica
            };
            Dictionary<Candy, int> Candies = new Dictionary<Candy, int>()
            {
                {HollandWaffles, 5},
                {Alenka, 3},
                {Lolli, 6},
                {Cracen, 7},
                {Lakrica, 5}
            };


            #endregion

            CreateXML(candies);

            #region Demonstration
            //Gift MyGift = new Gift("MyGift", Candies);
            //MyGift.FindBySugar(25, 26);
            //MyGift.OrderByName();
            //MyGift.OrderByMass();
            #endregion

            Console.ReadKey();
        }
    }
}
