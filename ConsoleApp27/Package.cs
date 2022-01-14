using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class Package
    {
        public Package(double weight, string city, int priority)
        {
            Weight = weight;
            City = city;
            Priority = priority;
        }

        public double Weight { get; set; }
        public string City { get; set; }
        public int Priority { get; set; }

    }
}
