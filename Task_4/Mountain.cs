using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Mountain : GeographicalObject
    {
        public double HighestPoint { get; }

        public Mountain(double x, double y, string name, string description, double highestPoint)
          : base(x, y, name, description)
        {
            HighestPoint = highestPoint;
        }

        public override string GetInformation()
        {
            return $"{base.GetInformation()} - {HighestPoint}m";
        }
    }
}
