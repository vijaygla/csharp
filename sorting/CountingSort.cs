using System;

class CountingSort
{
    static void CountingSortAlgo(int[] arr)
    {
        int max = arr[0];
        foreach (int num in arr)
            if (num > max) max = num;

        int[] count = new int[max + 1];

        // Count occurrences
        foreach (int num in arr)
            count[num]++;

        // Rebuild sorted array
        int index = 0;
        for (int i = 0; i < count.Length; i++)
        {
            while (count[i] > 0)
            {
                arr[index++] = i;
                count[i]--;
            }
        }
    }

    static void Main()
    {
        int[] arr = { 4, 2, 2, 8, 3, 3, 1 };
        Console.WriteLine("Original Array: " + string.Join(" ", arr));

        CountingSortAlgo(arr);

        Console.WriteLine("Sorted Array: " + string.Join(" ", arr));
    }
}
