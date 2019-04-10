using System;

namespace Exercise1_Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            var exe1 = new Exercise1();
            var exe2 = new Exercise2();
            var exe3 = new Exercise3();
            var exe4 = new Exercise4();

            Console.WriteLine("Excerise 1\n");
            exe1.ValidNumber();
            Console.WriteLine("\nExcerise 2\n");
            exe2.MaxNumber();
            Console.WriteLine("\nExcerise 3\n");
            exe3.Orientation();
            Console.WriteLine("\nExcerise 3\n");
            exe4.SpeedLimit();
        }
    }
}
