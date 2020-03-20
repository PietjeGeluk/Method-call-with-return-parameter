using System;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            Groet(); // Method call zonder parameters
            Add(3, 4);       // Method call met parameters signature with 2 types
            Add(3, 4, 5);    // Method call met parameters signature with 3 types

            Console.WriteLine(Cal(5, 6)); //Method call met return            
        }

        public static void Groet()
        {
            Console.WriteLine("Hello World!");
        }

        public static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static void Add(int num1, int num2, int num3)
        {
            Console.WriteLine(num1 + num2 - num3);
        }
        public static int Cal(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
