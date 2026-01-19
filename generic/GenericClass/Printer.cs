// A Generic Class allows us to write one class that works with different data types using a type parameter.

namespace generic.GenericClass
{
    // class generic
    class Printer<T>
    {
        public void Print(T data)
        {
            Console.WriteLine("Data : " + data);
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Printer<int> printerNumber = new Printer<int>();
            printerNumber.Print(101);

            Printer<string> printerName = new Printer<string>();
            printerName.Print("Epson");

            Printer<double> printerPrice = new Printer<double>();
            printerPrice.Print(2050.567);
        }
    }
}
