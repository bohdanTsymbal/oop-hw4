using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Interface
{
    internal interface IGeographicalObject
    {
        public double X { get; }
        public double Y { get; }
        public string Name { get; }
        public string Description { get; }

        public string GetInformation();
    }
}
