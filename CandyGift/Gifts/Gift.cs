using CandyGift.BaseCandyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGift.Gifts
{
    public class Gift
    {
        private IDictionary<int, Candy> _candies;
        private int _mass;

        public string Name { get; }
        public int Mass
        {
            get
            {
                return _mass;
            }
        }
        public IDictionary<int, Candy> Candies
        {
            get
            {
                return new Dictionary<int, Candy>(_candies);
            }
        }

        public Gift(string name, IDictionary<int, Candy> candies)
        {
            Name = name;
            _candies = candies;
            _mass = candies.Select(pair => pair.Key * pair.Value.Mass).Sum();
        }

        public void FindBySugar(int min, int max)
        {
            var sugar_list = from candy in _candies.Values
                             where candy is SweetCandy
                             select candy;
        }
    }
}
