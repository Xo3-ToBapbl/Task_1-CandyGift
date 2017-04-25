using CandyGift.BaseCandyClasses;
using CandyGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGift.Gifts
{
    public class Gift
    {
        private IDictionary<Candy, int> _candies;
        private int _mass;

        public string Name { get; }
        public int Mass
        {
            get
            {
                return _mass;
            }
        }
        public IDictionary<Candy, int> Candies
        {
            get
            {
                return new Dictionary<Candy, int>(_candies);
            }
        }

        public Gift(string name, IDictionary<Candy, int> candies)
        {
            Name = name;
            _candies = candies;
            _mass = candies.Select(pair => pair.Key.Mass * pair.Value).Sum();
        }

        public void FindBySugar(int min, int max)
        {
            if (min <= max)
            {
                var SweetCandyList = from candy in _candies.Keys
                                     where candy is SweetCandy
                                     select (SweetCandy)candy;

                var CandiesRangeSugarList = (from candy in SweetCandyList
                                            where candy.Sugar >= min && candy.Sugar <= max
                                            select candy).ToList();
                if (CandiesRangeSugarList.Count != 0)
                {
                    foreach (var candy in CandiesRangeSugarList)
                    {
                        Console.WriteLine("{0}'s with {1} g of sugar.", candy.Name, candy.Sugar);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No candy with preset sugar range.\n");
                }
                    
            }
            else
            {
                Console.WriteLine("Incorrect input. Max ratio is less than min ratio.\n");
            }
        }
        public void OrderByName()
        {
            var OrderedList = from candy in _candies.Keys
                              orderby candy.Name
                              select candy;
            foreach (var candy in OrderedList)
            {
                Console.WriteLine(candy.Name);
            }
            Console.WriteLine();
        }
        public void OrderByMass()
        {
            var OrderedList = from candy in _candies.Keys
                              orderby candy.Mass
                              select candy;
            foreach (var candy in OrderedList)
            {
                Console.WriteLine("{0} with mass {1} g.", candy.Name, candy.Mass);
            }
            Console.WriteLine();
        }
    }
}
