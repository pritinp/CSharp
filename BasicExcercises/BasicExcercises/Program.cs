using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Excercises taken from...
            // http://www.w3resource.com/csharp-exercises/basic/index.php

            //// 1. Write a C# Sharp program to print Hello and your name in a separate line.
            //Console.WriteLine("Hello");
            //Console.WriteLine("Pritin Patel");
            //Console.ReadLine();

            ////2.Write a C# Sharp program to print the sum of two numbers.
            //int x = 20;
            //int y = 40;
            //int z;

            //z = x + y;
            //Console.WriteLine("The sum of 2 numbers is: {0}", z);
            //Console.ReadLine();

            ////3.Write a C# Sharp program to print the result of dividing two numbers.
            //int x = 8;
            //int y = 2;
            //int z;

            //z = x / y;
            //Console.WriteLine("The result of dividing 2 numbers is: {0}", z);
            //Console.ReadLine();

            // using specified solution...
            //Console.WriteLine(8 / 2);
            //Console.ReadLine();


            //4.Write a C# Sharp program to print the result of the specified operations...
            //-1 + 4 * 6
            //(35 + 5) % 7
            //14 + -4 * 6 / 11
            //2 + 15 / 6 * 1 - 7 % 2

            //int x = 2 + 15 / 6 * 1 - 7 % 2;

            //Console.WriteLine("{0}", x);
            //Console.ReadLine();

            ////5.Write a C# Sharp program to swap two numbers.
            //int number1, number2, temp;
            //Console.Write("Enter the first number: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the Second number: ");
            //number2 = int.Parse(Console.ReadLine());

            //temp = number1;
            //number1 = number2;
            //number2 = temp;

            //Console.WriteLine("The First number is: " +number1);
            //Console.WriteLine("The Second number is: " +number2);
            //Console.ReadLine(); // why can't this be Console.Readline()?

            //6.Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
            int num1, num2, num3, mNum;
            Console.Write("Enter the first number to multiply: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second number to multiply: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the Third number to multiply: ");
            num3 = int.Parse(Console.ReadLine());

            mNum = num1 * num2 * num3;

            Console.WriteLine("The result of the 3 numbers multiplied is: " +mNum);
            Console.ReadLine();
        }
    }
}
