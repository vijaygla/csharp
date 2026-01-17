using System;

class QuickSort
{
    // Function to partition the array
    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; // Choose last element as pivot
        int i = low - 1;       // Index of smaller element

        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                // Swap arr[i] and arr[j]
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        // Swap arr[i + 1] and pivot
        int swapTemp = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = swapTemp;

        return i + 1;
    }

    // Recursive Quick Sort function
    static void QuickSortRecursive(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);

            // Recursively sort elements before and after partition
            QuickSortRecursive(arr, low, pi - 1);
            QuickSortRecursive(arr, pi + 1, high);
        }
    }

    static void Main()
    {
        int[] arr = { 10, 7, 8, 9, 1, 5 };

        Console.WriteLine("Original Array:");
        foreach (int num in arr)
            Console.Write(num + " ");
        Console.WriteLine();

        QuickSortRecursive(arr, 0, arr.Length - 1);

        Console.WriteLine("Sorted Array:");
        foreach (int num in arr)
            Console.Write(num + " ");
    }
}
