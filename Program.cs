using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CountryReaderList
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @" C:\Users\bruno\source\repos\CountryReader\book1.csv";
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();
            Country liliput = new Country("Lilliput", "LI", "Somewhere", 5000);

            //Adding New Value to List
            int lilliputIndex = countries.FindIndex(x => x.Population < 5000);
            countries.Insert(lilliputIndex, liliput);

            //Removing Value from List Example
            countries.Remove(liliput);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{country.Name}: {country.Population}");
            }
            Console.WriteLine($"{countries.Count} countries");
        }
    }
}
