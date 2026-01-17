using System;

class HeapSort
{
    // Function to build Max Heap
    static void BuildMaxHeap(int[] arr)
    {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
            MaxHeapify(arr, n, i);
    }

    static void MaxHeapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
            largest = left;

        if (right < n && arr[right] > arr[largest])
            largest = right;

        if (largest != i)
        {
            int temp = arr[i];
            arr[i] = arr[largest];
            arr[largest] = temp;

            MaxHeapify(arr, n, largest);
        }
    }

    // Function to build Min Heap
    static void BuildMinHeap(int[] arr)
    {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
            MinHeapify(arr, n, i);
    }

    static void MinHeapify(int[] arr, int n, int i)
    {
        int smallest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] < arr[smallest])
            smallest = left;

        if (right < n && arr[right] < arr[smallest])
            smallest = right;

        if (smallest != i)
        {
            int temp = arr[i];
            arr[i] = arr[smallest];
            arr[smallest] = temp;

            MinHeapify(arr, n, smallest);
        }
    }

    // Print array
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
            Console.Write(num + " ");
        Console.WriteLine();
    }

    static void Main()
    {
        int[] arr = { 4, 10, 3, 5, 1 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        // Build Max Heap
        BuildMaxHeap(arr);
        Console.WriteLine("Max Heap:");
        PrintArray(arr);

        // Build Min Heap
        BuildMinHeap(arr);
        Console.WriteLine("Min Heap:");
        PrintArray(arr);
    }
}
