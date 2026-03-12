public class Program
{
    public static string ReverseWord(string word)
    {
        string reversedWord = new string(word.Reverse().ToArray());
        return reversedWord;
    }
    static void Main()
    {
        Console.WriteLine("Enter input ");
        string input = Console.ReadLine();
        string[] arr = input.Split(" ");
        string result = "";

        for (int i = 0; i < arr.Length; i++)
        {
            result = ReverseWord(arr[i]);
            Console.Write(result);
            if (arr.Length != i) Console.Write(" ");
        }
    }
}
