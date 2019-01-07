using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(10, 2));
            Console.Read();
        }

        //This is the add function
        public static int Add(int num1, int num2) => num1 + num2;

        //This is the divide funtion
        public static double Divide(double num1, double num2)
        {
            try
            {
                return num1 / num2;
            }
            catch
            {
                Console.WriteLine("Can't divide by Zero!");
                return 0;
            }
        }

        //This is the multiply function
        public static int Multiply(int num1, int num2) => num1 / num2;

        //This is the Substract function
        public static int Substract(int num1, int num2) => num1 - num2;
    }
}
