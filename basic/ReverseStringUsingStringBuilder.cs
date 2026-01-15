using System;
using System.Text;

class ReverseStringUsingStringBuilder {

    public static string ReverseString(String s) {
        StringBuilder sb = new StringBuilder();

        for(int i=s.Length-1; i>=0; i--) {
            sb.Append(s[i]);
        }

        return sb.ToString();
    }

    static void Main(String[] args) {
        Console.Write("Enter any string: ");
        String s = Console.ReadLine();
        Console.WriteLine("Original string: " + s);

        string ans = ReverseString(s);
        Console.WriteLine("Reverse String: " + ans);
    }
}
