using CandyGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGift.BaseCandyClasses
{
    public abstract class Candy: ICandy
    {
        public string Name { get; }
        public int Mass { get; }
        public ICollection<object> PropertyList { get; protected set; }
        public string CandyType { get; protected set; }

        protected Candy(string name, int mass)
        {
            Name = name;
            Mass = mass;
        }

        public List<object> GetProperties()
        {
            return (List<object>)PropertyList;
        }
        public abstract void UpMainComponentBy(int ratio);
        public abstract void DownMainComponentBy(int ratio);
    }
}
