using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.model = "Superb";
            myCar.mark = "Skoda";
            myCar.regnumber = "123ABC";
            myCar.odo = 400;

            for (double i = 0; i < 85; i++)
            {
                myCar.Drive();
            }
            myCar.ShowOdo();
        }
    }
}
