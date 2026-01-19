// A Generic Method allows a method to operate on different data types using type parameters, ensuring type safety and reusability.

namespace generic.GenericMethod
{
    class Printer
    {
        public void Print<T>(T data) {
            Console.WriteLine("Data : " + data);
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Printer printer = new Printer();
            printer.Print<int>(102);
            printer.Print<string>("Epson");
            printer.Print<double>(2050.567);
        }
    }
}
