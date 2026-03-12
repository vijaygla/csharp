class Program
{
    public static string ConvertToInches(double value, string unit)
    {
        if (value <= 0)
        {
            return "Invalid value";
        }
        if (unit == "Feet" || unit == "feet" || unit == "FEET")
        {
            return (value * 12).ToString();
        }
        else if (unit == "Yard" || unit == "YARD" || unit == "yard")
        {
            return (value * 36).ToString();
        }
        else
        {
            return "Invalid unit";
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter input value");
        double value = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter input unit(yard/feet)");
        string unit = Console.ReadLine();
        string result = ConvertToInches(value, unit);
        Console.WriteLine($"{value} {unit} = {result} inches");
    }
}
