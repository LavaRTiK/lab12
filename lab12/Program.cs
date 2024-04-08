using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Завдання
            /*
             Вводиться список стадіонів заданих як місто, регіон в якому вони знаходяться та
кількість посадкових місць. Окремо вводиться кількість осіб яких треба розмістити.
Необхідно вибрати регіони які можуть розмістити шукану кількість місць та вивести
стадіони з цих регіонів в відсортовані за кількістю місць
            */
            #endregion
            List<City> list = new List<City>()
            {
                new City("Vinnisya",new Region("Zamostia",new Stadium("Niva",320))),
                new City("Kiev",new Region("Tremid",new Stadium("Locat",560)))

            };
            list[0].AddRegion(new Region("Vishenka",new Stadium("Mayak",90)));
            list[0].GetRegions()[0].AddStation(new Stadium("Lokamativ",420));
            list[0].AddRegion(new Region("Lenskiy", new Stadium("Cetrail", 230)));
            List<City> result = new List<City>();
            foreach (City city in list)
            {
                city.Print();
            }
            //Ввод сільки міц розмістити
            int needPlace;
            while (true) {
                Console.WriteLine("Введіть кількіть людей");
                if (int.TryParse(Console.ReadLine(),out needPlace))
                {
                    break;
                }
                Console.WriteLine("Не вірно вказано данні");
            }
            var Query = list
                .SelectMany(city => city.GetRegions().SelectMany(r => r.GetStadions().Where(s => s.GetCoutPlace() >= needPlace)))
                .OrderByDescending(s => s.GetCoutPlace())
                .ToList();
                //.SelectMany(city => city.GetRegions().Where(region => region.GetStadions().Any(stadium => stadium.GetCoutPlace() >= needPlace))).ToList();
            foreach(Stadium vlue in Query)
            {
                Console.WriteLine(vlue.GetDataString());
            }
            Console.ReadLine();
        }
    }
}
