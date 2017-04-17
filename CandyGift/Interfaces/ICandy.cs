using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGift.Interfaces
{
    interface ICandy
    {
        string type { get; }
        string name { get; }
        string sugar { get; }
        string toppig { get; }
        int mass { get; }
    }
}
