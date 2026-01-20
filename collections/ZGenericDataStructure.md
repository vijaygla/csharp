# 🌍 Real-Life Uses of Data Structures  

Well-organized notes explaining **definition, when to use, real-life examples, and industry applications** of data structures.

---

## 🔢 1. Array

### 📘 Definition  
An **array** is a linear data structure that stores elements of the **same data type** in **contiguous memory locations** and allows **direct access using an index**.

### ✅ When to Use
✔ Fixed-size data  
✔ Fast index-based access  
✔ Data rarely changes  

### 🌍 Real-Life Use
🎟 Seats in a cinema  
📊 Monthly sales record  

### 🏭 Industry Use
🖼 Image pixels  
🎮 Game boards  
📡 Sensor data buffers  

---

## 🔗 2. Linked List

### 📘 Definition  
A **linked list** is a dynamic data structure where elements (nodes) are connected using **references/pointers**, and memory is **non-contiguous**.

### ✅ When to Use
✔ Frequent insertions/deletions  
✔ Size not known in advance  
✔ No random access needed  

### 🌍 Real-Life Use
🚆 Train coaches  
🎵 Music playlist  

### 🏭 Industry Use
🌐 Browser navigation  
🧠 Memory management  
↩ Undo / Redo systems  

---

## 📚 3. Stack (LIFO)

### 📘 Definition  
A **stack** is a linear data structure that follows **Last In First Out (LIFO)**.

### ✅ When to Use
✔ Last task executed first  
✔ Backtracking required  

### 🌍 Real-Life Use
🍽 Stack of plates  
↩ Undo feature  

### 🏭 Industry Use
⚙ Function call stack  
🧮 Expression evaluation  
🌲 DFS traversal  

---

## 🚶 4. Queue (FIFO)

### 📘 Definition  
A **queue** follows the **First In First Out (FIFO)** principle.

### ✅ When to Use
✔ Order matters  
✔ First task served first  

### 🌍 Real-Life Use
🎫 Ticket counter queue  
🖨 Printer jobs  

### 🏭 Industry Use
🖥 CPU scheduling  
📥 Task queues  
📨 Message brokers (Kafka, RabbitMQ)  

---

## 🔁 5. Deque (Double Ended Queue)

### 📘 Definition  
A **deque** allows insertion and deletion from **both front and rear ends**.

### ✅ When to Use
✔ Flexible insertion/removal  
✔ Both-end operations  

### 🌍 Real-Life Use
🚆 Coaches added from front/back  

### 🏭 Industry Use
📐 Sliding window problems  
🧹 LRU cache  

---

## 🔐 6. Hash Table (Map / Dictionary)

### 📘 Definition  
A **hash table** stores data in **key–value pairs** using a **hash function** for fast access.

### ✅ When to Use
✔ Fast search/insert/delete → **O(1)**  
✔ Key-value mapping  

### 🌍 Real-Life Use
📞 Phone directory  
🎓 Roll number → marks  

### 🏭 Industry Use
🗄 Database indexing  
🔑 Authentication tokens  
⚡ Caching (Redis)  

---

## 🎯 7. Set

### 📘 Definition  
A **set** stores **unique elements only**, no duplicates allowed.

### ✅ When to Use
✔ Uniqueness required  
✔ Duplicate removal  

### 🌍 Real-Life Use
🆔 Unique IDs  
🎲 Lottery numbers  

### 🏭 Industry Use
🧹 Remove duplicates  
🔐 Permission systems  
🏷 Tag management  

---

## 🌳 8. Tree

### 📘 Definition  
A **tree** is a hierarchical data structure with **parent–child relationships**.

### ✅ When to Use
✔ Hierarchical data  
✔ Structured relationships  

### 🌍 Real-Life Use
👨‍👩‍👧 Family tree  
🏢 Organization chart  

### 🏭 Industry Use
📁 File systems  
🌐 DOM structure  
📄 XML / JSON parsing  

---

## 🌲 9. Binary Search Tree (BST)

### 📘 Definition  
A **BST** is a binary tree where  
**Left < Root < Right**

### ✅ When to Use
✔ Sorted data  
✔ Ordered searching  

### 🌍 Real-Life Use
📖 Dictionary words  
📇 Phone contacts  

### 🏭 Industry Use
📏 Range queries  
📂 Auto-sorted storage  

---

## 🏔 10. Heap

### 📘 Definition  
A **heap** is a complete binary tree used to quickly access the **minimum or maximum** element.

### ✅ When to Use
✔ Priority-based tasks  
✔ Min / Max retrieval  

### 🌍 Real-Life Use
🏥 Hospital emergency queue  

### 🏭 Industry Use
📌 Priority queues  
🗓 Job scheduling  
🛣 Dijkstra’s algorithm  

---

## 🕸 11. Graph

### 📘 Definition  
A **graph** consists of **vertices (nodes)** connected by **edges**, representing relationships.

### ✅ When to Use
✔ Relationships & networks  
✔ Pathfinding  

### 🌍 Real-Life Use
🗺 Road maps  
👥 Social networks  

### 🏭 Industry Use
📍 GPS navigation  
🤝 Recommendation systems  
🌐 Network routing  

---

## 🔤 12. Trie

### 📘 Definition  
A **trie** is a tree-based data structure used for **prefix-based string searching**.

### ✅ When to Use
✔ Prefix search  
✔ Fast word lookup  

### 🌍 Real-Life Use
⌨ Dictionary auto-suggest  

### 🏭 Industry Use
🔍 Search engines  
✍ Auto-complete  
📝 Spell checkers  

---

## 🧩 13. Matrix

### 📘 Definition  
A **matrix** is a two-dimensional array arranged in **rows and columns**.

### ✅ When to Use
✔ 2D data  
✔ Mathematical operations  

### 🌍 Real-Life Use
♟ Chess board  
📊 Excel sheet  

### 🏭 Industry Use
🖼 Image processing  
🤖 Machine learning  
🎮 Game development  

---

## 🔄 14. Circular Linked List

### 📘 Definition  
A **circular linked list** is a linked list where the **last node points to the first node**.

### ✅ When to Use
✔ Continuous looping  
✔ No fixed start/end  

### 🌍 Real-Life Use
🏆 Round-robin tournament  

### 🏭 Industry Use
🖥 CPU scheduling  
🎮 Multiplayer games  

---

## ⭐ 15. Priority Queue

### 📘 Definition  
A **priority queue** processes elements based on **priority**, not insertion order.

### ✅ When to Use
✔ Priority matters  
✔ Urgent tasks first  

### 🌍 Real-Life Use
✈ Airport boarding  

### 🏭 Industry Use
🤖 AI pathfinding  
⚡ Event-driven systems  
🧠 OS scheduling  

---

## 💡 16. Bit Manipulation / Bitset

### 📘 Definition  
Uses **bits (0/1)** to represent and manipulate data efficiently.

### ✅ When to Use
✔ Memory optimization  
✔ Boolean flags  

### 🌍 Real-Life Use
🔘 ON / OFF switches  

### 🏭 Industry Use
🔐 Permission flags  
📦 Data compression  
⚙ Low-level programming  

---

## 🔗 17. Disjoint Set (Union-Find)

### 📘 Definition  
A **disjoint set** keeps track of elements divided into **non-overlapping groups**.

### ✅ When to Use
✔ Connectivity checking  
✔ Group detection  

### 🌍 Real-Life Use
👫 Friend groups  

### 🏭 Industry Use
🌐 Network connectivity  
🧮 Kruskal’s algorithm  
🧩 Cluster detection  

---

## 📊 Summary Table

| Data Structure | Key Use |
|---------------|--------|
| Array | Fixed storage |
| Linked List | Dynamic data |
| Stack | Undo / Backtracking |
| Queue | Scheduling |
| HashMap | Fast lookup |
| Tree | Hierarchy |
| Graph | Networks |
| Heap | Priority handling |

---
# Collection framework
`The Collection Framework in C# is a set of classes and interfaces used to store, manage, and manipulate groups of objects dynamically`

## Categories of Collections in C#
```
Collections
│
├── Non-Generic Collections (System.Collections)
│
├── Generic Collections (System.Collections.Generic)
│
├── Concurrent Collections
│
└── Specialized Collections
```


## Flow Diagram
```
System.Collections
   |
   ├── IEnumerable
   │     └── ICollection
   │           ├── IList
   │           │     ├── ArrayList
   │           │     └── List<TType>
   │           ├── IDictionary
   │           │     ├── Hashtable
   │           │     └── Dictionary<TKey, TValue>
   │           └── Queue / Stack
```


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

