class Program
{
    static void Main(string[] args)
    {
        int[,] nums = new int[2, 3];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                nums[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMatrix");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(nums[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
