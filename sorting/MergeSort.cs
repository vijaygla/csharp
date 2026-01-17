using System;

class MergeSort
{
    // Merge two sorted subarrays L and R into arr
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        // Temporary arrays
        int[] L = new int[n1];
        int[] R = new int[n2];

        for (int i = 0; i < n1; i++)
            L[i] = arr[left + i];
        for (int j = 0; j < n2; j++)
            R[j] = arr[mid + 1 + j];

        int iIndex = 0, jIndex = 0, k = left;

        // Merge temp arrays back into arr
        while (iIndex < n1 && jIndex < n2)
        {
            if (L[iIndex] <= R[jIndex])
            {
                arr[k] = L[iIndex];
                iIndex++;
            }
            else
            {
                arr[k] = R[jIndex];
                jIndex++;
            }
            k++;
        }

        // Copy remaining elements
        while (iIndex < n1)
        {
            arr[k] = L[iIndex];
            iIndex++;
            k++;
        }

        while (jIndex < n2)
        {
            arr[k] = R[jIndex];
            jIndex++;
            k++;
        }
    }

    // Recursive Merge Sort
    static void MergeSortRecursive(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            // Sort first half
            MergeSortRecursive(arr, left, mid);
            // Sort second half
            MergeSortRecursive(arr, mid + 1, right);

            // Merge sorted halves
            Merge(arr, left, mid, right);
        }
    }

    static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6, 7 };

        Console.WriteLine("Original Array:");
        foreach (int num in arr)
            Console.Write(num + " ");
        Console.WriteLine();

        // Call Merge Sort
        MergeSortRecursive(arr, 0, arr.Length - 1);

        Console.WriteLine("Sorted Array:");
        foreach (int num in arr)
            Console.Write(num + " ");
    }
}
