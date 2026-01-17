using System;

class RadixSort
{
    static int GetMax(int[] arr)
    {
        int max = arr[0];
        foreach (int num in arr)
            if (num > max) max = num;
        return max;
    }

    static void CountSort(int[] arr, int exp)
    {
        int n = arr.Length;
        int[] output = new int[n];
        int[] count = new int[10];

        for (int i = 0; i < n; i++)
            count[(arr[i] / exp) % 10]++;

        for (int i = 1; i < 10; i++)
            count[i] += count[i - 1];

        for (int i = n - 1; i >= 0; i--)
        {
            int idx = (arr[i] / exp) % 10;
            output[count[idx] - 1] = arr[i];
            count[idx]--;
        }

        for (int i = 0; i < n; i++)
            arr[i] = output[i];
    }

    static void RadixSortAlgo(int[] arr)
    {
        int max = GetMax(arr);
        for (int exp = 1; max / exp > 0; exp *= 10)
            CountSort(arr, exp);
    }

    static void Main()
    {
        int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
        Console.WriteLine("Original Array: " + string.Join(" ", arr));

        RadixSortAlgo(arr);

        Console.WriteLine("Sorted Array: " + string.Join(" ", arr));
    }
}
