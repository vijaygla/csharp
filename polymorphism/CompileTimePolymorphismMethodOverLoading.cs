using System;

class Calculator {
    public int Add(int num1, int num2) {
        return num1 + num2;
    }

    public int Add(int num1, int num2, int num3) {
        return num1 + num2 + num3;
    }
}

class CompileTimePolymorphismMethodOverLoading {
    static void Main(String[] args) {
        Calculator calculator = new Calculator();

        int sumTwoNumbers = calculator.Add(5, 10);
        Console.WriteLine("Sum of two numbers: " + sumTwoNumbers);

        int sumThreeNumbers = calculator.Add(5, 10, 15);
        Console.WriteLine("Sum of three numbers: " + sumThreeNumbers);
    }
}
