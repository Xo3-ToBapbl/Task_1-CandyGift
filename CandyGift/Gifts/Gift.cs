using CandyGift.BaseCandyClasses;
using CandyGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CandyGift.Gifts
{
    public class Gift
    {
        private IList<ICandy> _candies_collection = new List<ICandy>();

        public string Name { get; }
        public int Mass
        {
            get
            {
                return _candies_collection.Select(candy => candy.Mass).Sum();
            }
        }
        public IList<ICandy> CandiesList
        {
            get
            {
                return new List<ICandy>(_candies_collection);
            }
        }

        public Gift(string name)
        {
            Name = name;
        }
        public Gift(string name, IList<ICandy> candies_collection) : this(name)
        {
            _candies_collection = _candies_collection.Concat(candies_collection).ToList();
        }

        public void AddCandy(ICandy candy)
        {
            _candies_collection.Add(candy);
        }
        public void RemoveAllCandiesByName(string name)
        {
            
            foreach (ICandy candy in CandiesList)
            {
                if (candy.Name == name)
                {
                    _candies_collection.Remove(candy);
                }
            }
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
                                       Cast<Candy>().
                                       ToList();
            return OrderedList;
        }
        public List<Candy> OrderByMass()
        {
            List<Candy> OrderedList = (from candy in _candies_collection
                                       orderby candy.Mass
                                       select candy).
                                       Cast<Candy>().
                                       ToList();
            return OrderedList;
        }
    }
}
