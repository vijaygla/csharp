// ArrayList (Non-Generic)

// ✔ Dynamic size
// ❌ Not type-safe

using System;
using System.Collections;

class Program {
    static void Main(String[] args) {
        ArrayList list = new ArrayList();

        list.Add(10);
        list.Add("Hello");
        list.Add(3.14);

        foreach (var item in list) {
            Console.WriteLine(item);
        }
    }
}
