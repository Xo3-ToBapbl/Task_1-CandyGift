using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGift.Interfaces
{
    interface ICandy
    {
        string Name { get; }
        int Mass { get; }
        ICollection<object> PropertyList { get; }

        List<object> GetProperties();
        void UpMainComponentBy(int ratio);
        void DownMainComponentBy(int ratio);
    }
}
