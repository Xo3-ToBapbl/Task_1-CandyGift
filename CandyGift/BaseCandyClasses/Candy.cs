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

        public void GetProperties()
        {
            Console.WriteLine("{0}'s properties:", CandyType);
            foreach (object property in PropertyList)
            {
                Console.WriteLine("{0}", property);
            }
            Console.WriteLine();
        }
        abstract public void UpMainComponentBy(int ratio);
        abstract public void DownMainComponentBy(int ratio);
    }
}
