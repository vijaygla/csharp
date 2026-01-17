using System;

class TimSort
{
    const int RUN = 32;

    static void InsertionSort(int[] arr, int left, int right)
    {
        for (int i = left + 1; i <= right; i++)
        {
            int temp = arr[i];
            int j = i - 1;
            while (j >= left && arr[j] > temp)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = temp;
        }
    }

    static void Merge(int[] arr, int l, int m, int r)
    {
        int len1 = m - l + 1, len2 = r - m;
        int[] left = new int[len1];
        int[] right = new int[len2];

        for (int x = 0; x < len1; x++)
            left[x] = arr[l + x];
        for (int x = 0; x < len2; x++)
            right[x] = arr[m + 1 + x];

        int i = 0, j = 0, k = l;

        while (i < len1 && j < len2)
        {
            if (left[i] <= right[j])
                arr[k++] = left[i++];
            else
                arr[k++] = right[j++];
        }

        while (i < len1) arr[k++] = left[i++];
        while (j < len2) arr[k++] = right[j++];
    }

    static void TimSortAlgo(int[] arr, int n)
    {
        // Sort individual subarrays of size RUN
        for (int i = 0; i < n; i += RUN)
            InsertionSort(arr, i, Math.Min(i + RUN - 1, n - 1));

        // Merge sorted subarrays
        for (int size = RUN; size < n; size = 2 * size)
        {
            for (int left = 0; left < n; left += 2 * size)
            {
                int mid = left + size - 1;
                int right = Math.Min((left + 2 * size - 1), (n - 1));

                if (mid < right)
                    Merge(arr, left, mid, right);
            }
        }
    }

    static void Main()
    {
        int[] arr = { 5, 21, 7, 23, 19, 3, 2, 10, 8 };
        int n = arr.Length;

        Console.WriteLine("Original Array: " + string.Join(" ", arr));

        TimSortAlgo(arr, n);

        Console.WriteLine("Sorted Array: " + string.Join(" ", arr));
    }
}
