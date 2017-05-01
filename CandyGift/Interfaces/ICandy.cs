using System.Collections.Generic;

namespace CandyGift.Interfaces
{
    public interface ICandy
    {
        string Name { get; }
        int Mass { get; }
        ICollection<object> PropertyList { get; }

        List<object> GetProperties();
        void UpMainComponentBy(int ratio);
        void DownMainComponentBy(int ratio);
    }
}
