using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Interface
{
    internal class Mountain : IGeographicalObject
    {
        public double X { get; }
        public double Y { get; }
        public string Name { get; }
        public string Description { get; }
        public double HighestPoint { get; }

        public Mountain(double x, double y, string name, string description, double highestPoint)
        {
            X = x;
            Y = y;
            Name = name;
            Description = description;
            HighestPoint = highestPoint;
        }

        public string GetInformation()
        {
            return $"{X}, {Y} - {Name} - {Description} - {HighestPoint}m";
        }
    }
}
