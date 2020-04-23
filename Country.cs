using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountryReader;

namespace CountryReader
{
    class Country

    {
        //Read Only Bag of properties
        public  string Name { get; }
        public string Code { get; }
        public string Region{ get; }
        public int Population { get; }

        //Constructor
        public Country(string name, string code, string region, int population)
        {
            this.Name = name;
            this.Code = code;
            this.Region = region;
            this.Population = population;
        }


    }
}
