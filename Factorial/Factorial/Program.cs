using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class factorial
    {
        public static double input()
        {
            Console.WriteLine("Enter number:");
            double number = int.Parse(Console.ReadLine());
            return number; 
        }

        public static void write(double someNumber)
        {
            Console.WriteLine("Fact({0}) = {1}", someNumber, fact(someNumber));
            Console.ReadKey();
        }
      

    public static double fact(double someNumber)
    {
        return someNumber == 1 ? someNumber : fact(someNumber - 1) * someNumber;

    }

public static void outData()
        {
            double someNumber = input();
            write(someNumber);
            
        }

        static void Main(string[] args)
        {
            outData();
        }
    }
}
