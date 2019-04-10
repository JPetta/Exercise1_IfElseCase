using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_Conditional
{
    class Exercise2
    {
        public void MaxNumber()
        {
            var Num1 = Convert.ToInt32(Console.ReadLine());
            var Num2 = Convert.ToInt32(Console.ReadLine());

            var max = (Num1 > Num2) ? Num1 : Num2;
            Console.WriteLine(max);
        }
    }
}
