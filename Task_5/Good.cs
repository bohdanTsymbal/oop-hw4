using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Good
    {
        public double Price { get; }
        public string OriginCountry { get; }
        public string Name { get; }
        public string PackingDate { get; }
        public string Description { get; }

        public Good(double price, string originCountry, string name, string packingDate, string description)
        {
            Price = price;
            OriginCountry = originCountry;
            Name = name;
            PackingDate = packingDate;
            Description = description;
        }   
    }
}
