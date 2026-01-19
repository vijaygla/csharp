// A Generic Interface allows us to define a type-safe contract that can be implemented by different classes for different data types.

using System;

namespace generic.GenericInterface      
{
    // generic interface
    interface IPrinter<T>
    {
        void Print(T data);
    }

    // string generic
    class StringPrint : IPrinter<string>
    {
        public void Print(string data)
        {
            Console.WriteLine("String Data : " + data);
        }
    }

    // int generic
    class IntPrint : IPrinter<int>
    {
        public void Print(int data)
        {
            Console.WriteLine("Int Data : " + data);
        }
    }

    // double gereric
    class DoublePrint : IPrinter<double>
    {
        public void Print(double data)
        {
            Console.WriteLine("Double Data : " + data);
        }
    }


    class Program
    {
        static void Main(String[] args)
        {
            IPrinter<string> printerName = new StringPrint();
            printerName.Print("Epson");
            
            IPrinter<int> printerNumber = new IntPrint();
            printerNumber.Print(103);

            IPrinter<double> printerPrice = new DoublePrint();
            printerPrice.Print(1050.567);
        }
    }
}
