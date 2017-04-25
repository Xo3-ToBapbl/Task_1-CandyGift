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
        static void CreateSweetCandies(XElement element, ref List<Candy> candies_list)
        {
            string name = element.Element("Name").Value;
            int mass = Convert.ToInt32(element.Element("Mass").Value);
            int sugar = Convert.ToInt32(element.Element("Sugar").Value);
            string topping = element.Element("Topping").Value;

            switch (element.Attribute("type").Value)
            {
                case "Waffle":
                    Waffles waffle = new Waffles(name, mass, sugar, topping);
                    candies_list.Add(waffle);
                    break;
                case "ChocolateCandy":
                    ChocolateCandy chocolate_candy = new ChocolateCandy(name, mass, sugar, topping);
                    candies_list.Add(chocolate_candy);
                    break;
                case "LolliPop":
                    LolliPop lolli_pop = new LolliPop(name, mass, sugar, topping);
                    candies_list.Add(lolli_pop);
                    break;
            }
        }
        static void CreateSaltedCandies(XElement element, ref List<Candy> candies_list)
        {
            string name = element.Element("Name").Value;
            int mass = Convert.ToInt32(element.Element("Mass").Value);
            int salt = Convert.ToInt32(element.Element("Salt").Value);
            

            switch (element.Attribute("type").Value)
            {
                case "Cracker":
                    Cracker cracker = new Cracker(name, mass, salt);
                    candies_list.Add(cracker);
                    break;
                case "Salmiak":
                    Salmiak salmiak = new Salmiak(name, mass, salt);
                    candies_list.Add(salmiak);
                    break;
            }
        }

        static void CreateXML(ICollection<Candy> candies)
        {
            XDocument xdoc = new XDocument();
            XElement xroot = new XElement("Candies");
            XElement xroot_sweet_candy = new XElement("SweetCandies");
            XElement xroot_salted_candy = new XElement("SaltedCandies");

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
                    xroot_sweet_candy.Add(candy_type);
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
                    xroot_salted_candy.Add(candy_type);
                }
            }
            #endregion
            xroot.Add(xroot_sweet_candy);
            xroot.Add(xroot_salted_candy);

            xdoc.Add(xroot);
            xdoc.Save("CandiesData.xml");
         }
        static List<Candy> LoadXML()
        {
            List<Candy> candies_list = new List<Candy>();

            XDocument xdoc = XDocument.Load("CandiesData.xml");
            foreach (XElement element in xdoc.Elements().Elements())
            {
                if (element.Name == "SweetCandies")
                {
                    foreach (XElement elmnt in element.Elements())
                    {
                        CreateSweetCandies(elmnt, ref candies_list);
                    }
                }
                if (element.Name == "SaltedCandies")
                {
                    foreach (XElement elmnt in element.Elements())
                    {
                        CreateSaltedCandies(elmnt, ref candies_list);
                    }
                }
            }
            return candies_list;
        }

        static void Main(string[] args)
        {
            List<Candy> candies_list = LoadXML();
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