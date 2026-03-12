class Program
{
    static void Main()
    {
        string filePath = "student.txt";
        Dictionary<string, int> StudentDict = new Dictionary<string, int>();

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split(",");

                    if (arr.Length == 2)
                    {
                        if (int.TryParse(arr[1], out int marks))
                        {
                            StudentDict[arr[0]] = marks;
                        }
                    }
                }

                if (StudentDict.Count > 0)
                {
                    string topScorer = "";
                    int highestMarks = 0;
                    double totalMarks = 0;

                    foreach (var kv in StudentDict)
                    {
                        if (kv.Value > highestMarks)
                        {
                            highestMarks = kv.Value;
                            topScorer = kv.Key;
                        }
                        totalMarks += kv.Value;
                    }

                    double average = totalMarks / StudentDict.Count;
                    Console.WriteLine($"Highest Scorer : {topScorer} || Highest Score : {highestMarks}");
                    Console.WriteLine($"Average Marks : {average}");
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File Not found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
