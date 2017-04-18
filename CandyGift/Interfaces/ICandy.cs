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
        string toppig { get; }
        string sugar { get; }
        int mass { get; }
    }
}
