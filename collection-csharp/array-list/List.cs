// List<T> (Generic) ⭐

// ✔ Type-safe
// ✔ Fast
// ✔ Most commonly used

using System;
using System.Collections.Generic;

class List {
    static void Main(String[] args) {
        List<int> list = new List<int>();

        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);

        foreach(int item in list) {
            Console.Write(item + " ");
        }
    }
}
