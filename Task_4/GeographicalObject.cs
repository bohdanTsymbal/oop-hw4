using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal abstract class GeographicalObject
    {
        public double X { get; }
        public double Y { get; }
        public string Name { get; }
        public string Description { get; }

        public GeographicalObject(double x, double y, string name, string description)
        {
            X = x;
            Y = y;
            Name = name;
            Description = description;
        }

        public virtual string GetInformation()
        {
            return $"{X}, {Y} - {Name} - {Description}";
        }
    }
}
