using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyGift.SweetCandies;
using CandyGift.SaltedCandies;

namespace Demonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            Waffles HollandWaffles = new Waffles("Holland Waffles", 24, 5, "Jam");
            HollandWaffles.GetProperties();

            Cracker Cracen = new Cracker("Cracen", 50, 8);
            Cracen.GetProperties();

            Console.ReadKey();
        }
    }
}
