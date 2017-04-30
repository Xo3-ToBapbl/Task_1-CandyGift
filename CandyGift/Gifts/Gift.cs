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
        private List<Candy> _candies_collection = new List<Candy>();

        public string Name { get; }
        public int Mass
        {
            get
            {                
                return _candies_collection.Select(candy => candy.Mass).Sum();
            }
        }
        public List<Candy> CandiesList
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
        public Gift(string name, List<Candy> candies_collection):this(name)
        {
            _candies_collection = _candies_collection.Concat(candies_collection).ToList();
        }

        public void AddCandy(Candy candy)
        {
            _candies_collection.Add(candy);
        }
        public void RemoveAllCandiesByName(string name)
        {
            _candies_collection.RemoveAll(x => x.Name == "Salmiak");
        }
        public void ClearGift()
        {
            _candies_collection.Clear();
        }

        public List<Candy> FindBySugar(int min, int max)
        {
            if (min <= max)
            {
                List<Candy> SweetCandyList = _candies_collection.
                    Where(x => x is SweetCandy).
                    Cast<SweetCandy>().
                    Where(x => x.Sugar >= min && x.Sugar <= max).
                    Cast<Candy>().
                    ToList();
                if (SweetCandyList.Count != 0)
                {
                    return SweetCandyList;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                throw new Exception("Incorrect input. Max ratio is less than min ratio.");
            }
        }
        public List<Candy> OrderByName()
        {
            List<Candy> OrderedList = (from candy in _candies_collection
                                       orderby candy.Name
                                       select candy).
                                       ToList();
            return OrderedList;
        }
    }
}
