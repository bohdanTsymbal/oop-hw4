using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Product : Good
    {
        public string ExpiryDate { get; }
        public double Quantity { get; }
        public string MeasurementUnit { get; }

        public Product(double price, string originCountry, string name, string packingDate, string description, 
            string expiryDate, double quantity, string measurementUnit) 
            : base(price, originCountry, name, packingDate, description)
        {
            ExpiryDate = expiryDate;
            Quantity = quantity;
            MeasurementUnit = measurementUnit;
        }   
    }
}
