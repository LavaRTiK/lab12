using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    public class Stadium
    {
        private string name;
        private int countPlace;

        public Stadium(string name,int countPlace)
        {
            this.name = name;
            this.countPlace = countPlace;
        }

        public string GetDataString()
        {
            return $" NameS:{name},Cout Place:{countPlace}";
        }
        public int GetCoutPlace()
        {
            return countPlace;
        }
    }
}
