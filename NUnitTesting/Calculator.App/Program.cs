using System;

namespace Calculator.App;

public class CalculatorClass
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Difference(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero");

        return a / b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        CalculatorClass c = new CalculatorClass();

        while(true)
        {
            Console.WriteLine("\n===== Calculator Menu =====");
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Difference");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter first number: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    int num2 = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Result: " + c.Sum(num1, num2));
                    break;
                case 2:
                    Console.Write("Enter first number: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + c.Difference(num1, num2));
                    break;
                case 3:
                    Console.Write("Enter first number: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + c.Multiply(num1, num2));
                    break;
                case 4:
                    try
                    {
                        Console.Write("Enter first number: ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.Write("Enter second number: ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result: " + c.Divide(num1, num2));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    break;
                
                case 5:
                    Console.WriteLine("Thank You");
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
