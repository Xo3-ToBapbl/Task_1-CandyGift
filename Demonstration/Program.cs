using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyGift.SweetCandies;

namespace Demonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            Waffles Candy1 = new Waffles("Candy1", 24, 5, "Jam");
            Candy1.GetProperties();
            Console.ReadKey();
        }
    }
}
