using System;
using System.Collections.Generic;

class BucketSort
{
    static void BucketSortAlgo(float[] arr)
    {
        int n = arr.Length;
        List<float>[] buckets = new List<float>[n];

        for (int i = 0; i < n; i++)
            buckets[i] = new List<float>();

        for (int i = 0; i < n; i++)
        {
            int idx = (int)(n * arr[i]);
            buckets[idx].Add(arr[i]);
        }

        for (int i = 0; i < n; i++)
            buckets[i].Sort();

        int index = 0;
        for (int i = 0; i < n; i++)
        {
            foreach (float val in buckets[i])
                arr[index++] = val;
        }
    }

    static void Main()
    {
        float[] arr = { 0.78f, 0.17f, 0.39f, 0.26f, 0.72f, 0.94f, 0.21f, 0.12f, 0.23f, 0.68f };
        Console.WriteLine("Original Array: " + string.Join(" ", arr));

        BucketSortAlgo(arr);

        Console.WriteLine("Sorted Array: " + string.Join(" ", arr));
    }
}
