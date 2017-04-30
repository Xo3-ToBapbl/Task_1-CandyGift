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
        private ICollection<Candy> _candies_collection = new List<Candy>();

        public string Name { get; }
        public int Mass
        {
            get
            {                
                return _candies_collection.Select(candy => candy.Mass).Sum();
            }
        }
        public ICollection<Candy> CandiesList
        {
            get
            {
                return new List<Candy>(_candies_collection);
            }
        }

        public Gift(string name)
        {
            Name = name;
        }
        public Gift(string name, ICollection<Candy> candies_collection):this(name)
        {
            _candies_collection = _candies_collection.Concat(candies_collection).ToList();
        }

        public void AddCandy(Candy candy)
        {
            _candies_collection.Add(candy);
        }
        //public void RemoveByName()
        public void ClearGift()
        {
            _candies_collection.Clear();
        }

        //public void GetMass()
        //{
        //    Console.WriteLine("Gift mass: {0} g.\n", Mass);
        //}
        //public void FindBySugar(int min, int max)
        //{
        //    if (min <= max)
        //    {
        //        var SweetCandyList = from candy in _candies.Keys
        //                             where candy is SweetCandy
        //                             select (SweetCandy)candy;

        //        var CandiesRangeSugarList = (from candy in SweetCandyList
        //                                    where candy.Sugar >= min && candy.Sugar <= max
        //                                    select candy).ToList();
        //        if (CandiesRangeSugarList.Count != 0)
        //        {
        //            foreach (var candy in CandiesRangeSugarList)
        //            {
        //                Console.WriteLine("{0}'s with {1} g of sugar.", candy.Name, candy.Sugar);
        //            }
        //            Console.WriteLine();
        //        }
        //        else
        //        {
        //            Console.WriteLine("No candy with preset sugar range.\n");
        //        }
                    
        //    }
        //    else
        //    {
        //        Console.WriteLine("Incorrect input. Max ratio is less than min ratio.\n");
        //    }
        //}
        //public void OrderByName()
        //{
        //    var OrderedList = from candy in _candies.Keys
        //                      orderby candy.Name
        //                      select candy;
        //    foreach (var candy in OrderedList)
        //    {
        //        Console.WriteLine(candy.Name);
        //    }
        //    Console.WriteLine();
        //}
        //public void OrderByMass()
        //{
        //    var OrderedList = from candy in _candies.Keys
        //                      orderby candy.Mass
        //                      select candy;
        //    foreach (var candy in OrderedList)
        //    {
        //        Console.WriteLine("{0} with mass {1} g.", candy.Name, candy.Mass);
        //    }
        //    Console.WriteLine();
        //}
    }
}
