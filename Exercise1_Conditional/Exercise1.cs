using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_Conditional
{
    public class Exercise1
    {
        public void ValidNumber()
        {
            var number = Console.ReadLine();
            var input = Convert.ToInt32(number);

            if (input == 3)
            {
                Console.WriteLine("number is valid");
            }
            else
            {
                Console.WriteLine("number is invalid");
            }
        }
    }
}
