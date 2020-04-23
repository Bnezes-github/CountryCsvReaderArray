using System.Collections.Generic;
using System.IO;

namespace CountryReaderList
{
    class CsvReader
    {
        private string _csvFilePath;
        public CsvReader(string cvsFilePath)
        {
            this._csvFilePath = cvsFilePath;
        }
        public List<Country> ReadAllCountries() 
        {
            List<Country> countries = new List<Country>();

            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                //read header line
                sr.ReadLine();

                string csvLine;

                while ((csvLine = sr.ReadLine()) != null)
                {
                    countries.Add(ReadCountryFromCvsLine(csvLine));
                }
               
            }
                return countries;
        }
        public Country ReadCountryFromCvsLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');
            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = int.Parse(parts[3]);

            return new Country(name, code, region, population);

        }

    }
}