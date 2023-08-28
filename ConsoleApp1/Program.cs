using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringDataTypes();
            //Console.ReadKey();
            OperatorsAndNumber();
            Console.ReadKey();
        }

        static void StringDataTypes()
        {
            string firstName;
            string lastName;
            string eSport;

            Console.Write("Howdy, what is your first name?");
            firstName = Console.ReadLine();
            Console.Write("Thanks. What is your last name?");
            lastName = Console.ReadLine();
            Console.Write("What eSport are you registering for?");
            eSport = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Welcome {firstName} {lastName}. I have you registered for {eSport}!");
        }

        static void OperatorsAndNumbers()
        {
            double num1;
            double num2;
            double num3;
            double num4;

            Console.Write("Enter a value for your first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for your second number: ");
            num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for your third number: ");
            num3 = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for your fourth number: ");
            num4 = double.Parse(Console.ReadLine());


            double addition = num1 + num2;
            double subtraction = num1 - num2;
            double multiplication = num1 * num2;
            double division = num1 / num2;

            Console.WriteLine($"Addition of {num1} + {num2} = {addition}");
            Console.WriteLine($"Subtraction of {num1} - {num2} = {subtraction}");
            Console.WriteLine($"Multiplication of {num1} * {num2} = {multiplication}");
            Console.WriteLine($"Division of {num1} / {num2} = {division}");
        }

        static void OperatorsAndNumber()
        {
            double num1;
            double num2;
            double result;
            string operation;

            Console.Write("Enter a value for your first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for your second number: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation (+, -, *, /):");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;

            }
            Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");
        }
    }
}
