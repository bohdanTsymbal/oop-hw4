using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Interface
{
    internal class River : IGeographicalObject
    {
        public double X { get; }
        public double Y { get; }
        public string Name { get; }
        public string Description { get; }
        public double FlowSpeed { get; }
        public double Length { get; }

        public River(double x, double y, string name, string description, double flowSpeed, double length)
        {
            X = x;
            Y = y;
            Name = name;
            Description = description;
            FlowSpeed = flowSpeed;
            Length = length;
        }

        public string GetInformation()
        {
            return $"{X}, {Y} - {Name} - {Description} - {FlowSpeed} sm/s - {Length}m";
        }
    }
}
