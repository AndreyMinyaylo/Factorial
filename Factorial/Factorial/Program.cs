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
            return someNumber == 1 ? someNumber : fact(someNumber - 1)*someNumber;

        }

        public static void outData()
        {
            double someNumber = input();
            write(someNumber);

        }
    }

    class factorialCuclic
        {

        public static void write(double someNumber)
        {
            Console.WriteLine("Fact({0}) = {1}", someNumber, fact(someNumber));
            Console.ReadKey();
        }


        public static double fact(double someNumber)
        {
            if (someNumber == 1)
                        {
                            return 1;
                        }
                    else
         {
                someNumber = fact(someNumber - 1) * someNumber;
                                return someNumber;
                        }
        }

        public static void outData()
            {
                double someNumber = factorial.input();
                write(someNumber);
            }


        
    }

    class consoleOut
    {
        static void Main(string[] args)
        {
            factorial.outData();
            factorialCuclic.outData();
        }
    }
}
