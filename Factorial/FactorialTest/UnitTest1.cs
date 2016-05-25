using System;
using System.Security.AccessControl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;


namespace FactorialTest
{
    [TestFixture]
    public class UnitTestFactorial
    {
        public static double input()
            {
                Console.WriteLine("Enter number:");
                double number = int.Parse(Console.ReadLine());
                return number;
            }

        [TestCase(5, "Fact(5) = 120")] //5!
        [TestCase(10, "Fact(10) = 3628800")] //10!
        [TestCase(15, "Fact(15) = 1307674368000")] //15!
        [TestCase(17, "Fact(17) = 355687428096000")] //17!
        public static void write(double someNumber, string st)
        {
            var sr = string.Empty;
            sr = string.Format("Fact({0}) = {1}", someNumber, fact(someNumber));
            // Console.ReadKey();
            Assert.AreEqual(st, sr);
        }


        public static double fact(double someNumber)
        {
            return someNumber == 1 ? someNumber : fact(someNumber - 1)*someNumber;

        }
    }
}


