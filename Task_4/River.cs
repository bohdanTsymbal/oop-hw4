using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class River : GeographicalObject
    {
        public double FlowSpeed { get; }
        public double Length { get; }

        public River(double x, double y, string name, string description, double flowSpeed, double length) 
            : base(x, y, name, description)
        {
            FlowSpeed = flowSpeed;
            Length = length;
        }

        public override string GetInformation()
        {
            return $"{base.GetInformation()} - {FlowSpeed} sm/s - {Length}m";
        }
    }
}
