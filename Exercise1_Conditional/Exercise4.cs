using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_Conditional
{
    class Exercise4
    {
        public void SpeedLimit()
        {
            Console.WriteLine("What is the speed limit in Km?\n");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWhat is the speed of the car?\n");
            var speedOfCar = Convert.ToInt32(Console.ReadLine());

            if (speedOfCar < speedLimit)
            {
                Console.WriteLine("Nope");
            }
            else
            {
                var demeritPoint = (speedOfCar - speedLimit) / 5;
                var conclusion = (demeritPoint > 12) ? "License Suspended" : Convert.ToString(demeritPoint);
                Console.WriteLine(conclusion);
            }

        }
    }
}
