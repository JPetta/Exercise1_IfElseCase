using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_Conditional
{
    class Exercise3
    {
        public void Orientation()
        {
            Console.WriteLine("Input Width");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Height");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = (width > height) ? "landscape" : "potrait";
            Console.WriteLine(orientation);
        }
    }
}
