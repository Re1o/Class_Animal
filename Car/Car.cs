using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Car
    {
        public string model;
        public string mark;
        public string colour;
        public string regnumber;
        public double odo = 0;

        public void Drive()
        {
            odo += 100;
        }
        public void ShowOdo()
        {
            Console.WriteLine($"The car {model} {mark} {regnumber} has driven {odo} km.");

        }

    }
}
