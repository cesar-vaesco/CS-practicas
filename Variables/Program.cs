
using System;

namespace Variables 
{ 
    class Program
    {
        private static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 2;
            Console.WriteLine("Numero 1 = " + number1);
            Console.WriteLine(number2);
            number1 = 3;
            Console.WriteLine("Número1 =  " + number1);
            int number3 = number1+ number2;
            Console.WriteLine(number3);
        }
    }
}