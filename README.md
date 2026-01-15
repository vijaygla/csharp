# Collection framework
`The Collection Framework in C# is a set of classes and interfaces used to store, manage, and manipulate groups of objects dynamically`


## Flow Diagram

- System.Collections
-    |
-    ├── IEnumerable
-    │     └── ICollection
-    │           ├── IList
-    │           │     ├── ArrayList
-    │           │     └── List<TType>
-    │           ├── IDictionary
-    │           │     ├── Hashtable
-    │           │     └── Dictionary<TKey, TValue>
-    │           └── Queue / Stack
---


### Types of collection
1. *Non generic collection*
    - store object type, not type-safe(array-list, hashtable, stack, queue)
    - `using System.Collections`
2. *Generic Collection*
    - store object types, type-safe, no boxing/unboxing
    - `System.Collections.Generic`
        #### Example
        - List<TType>
        - Dictionary<TKey, TValue>
        - Stack<TType>
        - Queue<TType>
        - HashSet<TType>

