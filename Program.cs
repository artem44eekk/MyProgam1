using System;

namespace MyProgram1
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.Write("Enter your First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter your Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"My name is {firstName} {lastName}, I'm {age} years old.");
            Console.ReadKey();

            // task 2
            int a = 3;
            int b = 9;
            double result;
            result = (Math.Pow(a + b, 4) - (Math.Pow(a, 4) + 4 * Math.Pow(a, 3) * b)) / (6 * Math.Pow(a, 2) * Math.Pow(b, 2) + 4 * a * Math.Pow(b, 3) + Math.Pow(b, 4));
            Console.WriteLine("result = {0}", result);
            Console.ReadKey();

            // task 3
            Console.Write("Enter a three-digit number: ");
            int num = int.Parse(Console.ReadLine());
            int reversed = (num % 10 * 100) + ((num / 10) % 10 * 10) + (num / 100);
            Console.WriteLine(num + " --> " + reversed);
            Console.ReadKey();
        }   
    }
}
