using System;

namespace Generic.GenericDelegate
{
    // Generic Delegate
    delegate void Printer<T>(T data);

    class Program
    {
        // Methods matching delegate
        static void StringPrinter(string data)
        {
            Console.WriteLine("String Data : " + data);
        }

        static void IntPrinter(int data)
        {
            Console.WriteLine("Int Data : " + data);
        }

        static void DoublePrinter(double data)
        {
            Console.WriteLine("Double Data : " + data);
        }

        // Main method
        static void Main(string[] args)
        {
            // Delegate for string
            Printer<string> printerName = StringPrinter;
            printerName("Epson");

            // Delegate for int
            Printer<int> printerNumber = IntPrinter;
            printerNumber(104);

            // Delegate for double
            Printer<double> printerPrice = DoublePrinter;
            printerPrice(1050.567);
        }
    }
}
