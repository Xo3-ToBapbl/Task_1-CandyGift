using CandyGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGift.Candies
{
    public class Candy : ICandy
    {
        public string Name { get; }
        public int Mass { get; }
        public ICollection<object> PropertyList { get; protected set; }

        protected Candy(string name, int mass)
        {
            Name = name;
            Mass = mass;
            PropertyList = new List<object> { Name, Mass };
        }

        public void GetProperties()
        {
            Console.WriteLine("{0}'s properties:", Name);
            foreach(object property in PropertyList)
            {
                Console.WriteLine("{0}", property);
            }
        }
        public virtual void UpMainComponentBy(int property)
        { 
        }
        public virtual void DownMainComponentBy(int property)
        {
        }       
    }
}
