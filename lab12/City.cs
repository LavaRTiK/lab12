using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    public class City
    {
        private string name;
        private List<Region> regions = new List<Region>();
        public City(string name)
        {
            this.name = name;
        }
        public City(string name,Region region)
        {
            this.name=name;
            this.regions.Add(region);
        }
        
        public void Print()
        {
            //вивід стадіонів
            string str = "";
            foreach(Region region in regions)
            {
                str = str + region.GetStadionsString() + "|";
            }
            Console.WriteLine($"Name:{name} | Regions:{str}");

        }
        public void AddRegion(Region region)
        {
            regions.Add(region);
        }
        public List<Region> GetRegions()
        {
            return regions;
        }
    }
}
