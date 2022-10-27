using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Book : Good
    {
        public int PagesNumber { get; }
        public string Publisher { get; }
        public string Authors { get; }

        public Book(double price, string originCountry, string name, string packingDate, string description, 
            int pagesNumber, string publisher, string authors) 
            : base(price, originCountry, name, packingDate, description)
        {
            PagesNumber = pagesNumber;
            Publisher = publisher;
            Authors = authors;
        }
    }
}
