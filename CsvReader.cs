﻿using System.IO;

namespace CountryReader
{
    class CsvReader
    {
        private string _csvFilePath;
        public CsvReader(string cvsFilePath)
        {
            this._csvFilePath = cvsFilePath;
        }
        public Country[] ReadFirstNCountries(int nCountries)
        {
            Country[] countries = new Country[nCountries];

            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                //read header line
                sr.ReadLine();
                for (int i = 0; i < nCountries; i++)
                {
                    string csvLine = sr.ReadLine();
                    countries[i] = ReadCountryFromCvsLine(csvLine);
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