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

        
    }

    class factorialWhithCycle
    {
        public static void result(double someNumber)
        {
            double resultFactorial = 1;
            for (double i = 1; i <=Convert.ToDouble(someNumber); i++)
            {
                 resultFactorial = resultFactorial * i;
            }
            Console.Write("Factorial number {0} is {1} ", someNumber, resultFactorial);
            Console.ReadLine();
        }

        public static void outData()
        {
            double someNumber = factorial.input();
            result(someNumber);

        }
            
    }

    class consoleOut
    {
        static void Main(string[] args)
        {
            factorial.outData();
            factorialWhithCycle.outData();
        }
    }
}
