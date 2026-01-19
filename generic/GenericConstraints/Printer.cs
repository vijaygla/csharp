// Generic constraints restrict the type parameter to specific types to ensure safe operations and better compile-time checking.

namespace generic.GenericConstraints
{
    class Printer<T> where T : class
    {
        public void Print(T data)
        {
            Console.WriteLine("Data : " + data);
        }
    }

    class Documents
    {
        public string DocumentsName {get; set;}

        public override string ToString()
        {
            return DocumentsName;
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Printer<Documents> docPrinter = new Printer<Documents>();
            docPrinter.Print(new Documents {DocumentsName = "Doc file sheet------"});
        }
    }
}
