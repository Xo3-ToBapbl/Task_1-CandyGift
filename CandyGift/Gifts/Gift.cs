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

                var CandiesRangeSugarList = from candy in SweetCandyList
                                  where candy.Sugar >= min && candy.Sugar <= max
                                  select candy;

                foreach (var candy in CandiesRangeSugarList)
                {
                    Console.WriteLine(candy.Name);
                }
            }
            else
            {
                Console.WriteLine("Incorrect input. Max ratio is less than min ratio.");
            }



        }
    }
}
