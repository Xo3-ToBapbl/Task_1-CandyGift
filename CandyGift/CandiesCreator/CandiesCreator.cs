using CandyGift.BaseCandyClasses;
using CandyGift.SaltedCandies;
using CandyGift.SweetCandies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyGift.CandiesCreator
{
    public class CandiesCreator
    {
        private ICollection<Candy> candy_list = new List<Candy>();
        public List<Candy> CandyList
        {
            get
            {
                return new List<Candy>(candy_list);
            } 
        }

        public CandiesCreator() { }

        public void CreateWaffles(string name, int mass, int sugar, string topping, byte count=1)
        {
            for(int n=0; n<count; n++ )
            {
                candy_list.Add(new Waffles(name, mass, sugar, topping));
            }
        }
        public void CreateLolliPop(string name, int mass, int sugar, string topping, byte count = 1)
        {
            for (int n = 0; n < count; n++)
            {
                candy_list.Add(new LolliPop(name, mass, sugar, topping));
            }
        }
        public void CreateChocolateCandy(string name, int mass, int sugar, string topping, byte count = 1)
        {
            for (int n = 0; n < count; n++)
            {
                candy_list.Add(new ChocolateCandy(name, mass, sugar, topping));
            }
        }

        public void CreateCracker(string name, int mass, int salt, byte count = 1)
        {
            for (int n = 0; n < count; n++)
            {
                candy_list.Add(new Cracker(name, mass, salt));
            }
        }
        public void CreateSalmiak(string name, int mass, int salt, byte count = 1)
        {
            for (int n = 0; n < count; n++)
            {
                candy_list.Add(new Salmiak(name, mass, salt));
            }
        }

        public void ClearCandyList()
        {
            candy_list.Clear();
        }
    }
}
