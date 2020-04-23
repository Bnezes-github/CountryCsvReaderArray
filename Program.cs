using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountryReader;

namespace CountryReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @" C:\Users\bruno\source\repos\CountryReader\book1.csv";
            CsvReader reader = new CsvReader(filePath);

            Country[] countries = reader.ReadFirstNCountries(10);
            foreach (Country country in countries)
            {
                Console.WriteLine($"{country.Name}: {country.Population}");
            }
            Console.WriteLine();
        }
        public void Listing()
        {
            List<string> daysOfTheWeek = new List<string>
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Saturday",
                "Friday",
                "Friday"
            };

            /* or
            List<string> daysOfTheWeek = new List<string>();
            daysOfTheWeek.Add("Monday");
            daysOfTheWeek.Add("Monday");
            daysOfTheWeek.Add("Monday");
            daysOfTheWeek.Add("Monday");
            daysOfTheWeek.Add("Friday");
            daysOfTheWeek.Add("Friday"); */
            
       
        }
    }
}
