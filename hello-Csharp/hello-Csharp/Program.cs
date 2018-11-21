using System;

namespace helloCsharp {
    class MainClass {
        public static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            Console.WriteLine("Hello World!");
            Console.WriteLine(Add());
          }

        public static int Add() {
            Console.WriteLine("Enter the first number");
            string numberInput = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string number2Input = Console.ReadLine();
            int num1 = int.Parse(numberInput);
            int num2 = int.Parse(number2Input);
            return num1 + num2;
        }
    }
}
