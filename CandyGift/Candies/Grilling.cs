using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyGift.Interfaces;


namespace CandyGift.Candies
{
    class Grilling:ICandy
    {
        public string type { get; }
        public string name { get; }
        public string sugar { get; }
        public string toppig { get; }
        public int mass { get; }
    }
}
