using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    public class Region
    {
        private string nameRegion;
        private int regionStationsCout;

        private List<Stadium> stadions = new List<Stadium>();

        public Region(string name)
        {
            this.nameRegion = name;
            this.stadions = new List<Stadium>();
        }
        public Region(string name, Stadium stadium)
        {
            this.nameRegion = name;
            //this.stadions = new List<Stadium>();
            this.stadions.Add(stadium);
            this.regionStationsCout = stadium.GetCoutPlace();
        }
        public void AddStation(Stadium stadion)
        {
            stadions.Add(stadion);
            regionStationsCout += stadion.GetCoutPlace();
        }
        public string GetName()
        {
            return nameRegion;
        }
        public string GetStadionsString()
        {
            string str = $"{nameRegion}:";
            foreach(var stadium in stadions)
            {
                str = str + stadium.GetDataString() + " ";
            }
            return str;
        }
        public List<Stadium> GetStadions()
        {
            return stadions;
        }
    }
}
