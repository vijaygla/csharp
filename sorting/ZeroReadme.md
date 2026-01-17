## 🔹 Bubble Sort
### When to Use
- Learning basics
- Very small datasets

### Real-Life Example
- Sorting 5 test scores manually

❌ Not used in industry

---

## 🔹 Selection Sort
### When to Use
- Minimum memory writes required
- Small datasets

### Real-Life Example
- Selecting top 3 winners from a small list

❌ Rarely used

---

## 🔹 Insertion Sort
### When to Use
- Data is almost sorted
- Small datasets
- Frequent insertions

### Real-Life Example
- Adding a student to a sorted attendance list
- Arranging playing cards

✅ Used internally for small arrays

---

## 🔹 Merge Sort
### When to Use
- Large datasets
- Stability required
- Predictable performance

### Real-Life Example
- Sorting bank transactions
- External file sorting

✅ Used in databases and big data

---

## 🔹 Quick Sort
### When to Use
- Fast average performance
- In-memory sorting
- Stability not required

### Real-Life Example
- Sorting products by price
- Ranking users by score

✅ Most commonly used general-purpose sort

---

## 🔹 Heap Sort
### When to Use
- Memory is limited
- Need guaranteed performance
- Priority-based problems

### Real-Life Example
- Job scheduling
- Finding top-K elements

✅ Used in system-level programming

---

## 🔹 Counting Sort
### When to Use
- Small and known integer range
- High-speed requirement

### Real-Life Example
- Sorting student marks (0–100)
- Counting age groups

✅ Very fast for limited range data

---

## 🔹 Radix Sort
### When to Use
- Fixed-length numbers or strings
- Large datasets

### Real-Life Example
- Sorting phone numbers
- Sorting ID numbers

✅ Used in high-performance systems

---

## 🔹 Bucket Sort
### When to Use
- Uniformly distributed data
- Floating-point numbers

### Real-Life Example
- Sorting percentages
- Sorting exam scores by range

⚠️ Used in special cases

---

## 🔹 Tim Sort ⭐
### When to Use
- Real-world data
- Partially sorted data
- Stability required

### Real-Life Example
- Sorting names
- Sorting logs by timestamp



---

# 🧠 One-Glance Decision Table

| Scenario | Best Sorting |
|--------|--------------|
| Small data | Insertion |
| Nearly sorted | Insertion / Tim |
| Large data | Merge / Tim |
| Fast average case | Quick |
| Memory critical | Heap |
| Small integer range | Counting |
| Fixed-length numbers | Radix |
| Uniform distribution | Bucket |
| Real-world apps | Tim |

---

## 📊 Comparison Table (Quick Revision)

| Sort      | Best     | Avg        | Worst      | Stable | In-Place | Space Complexity |
|-----------|----------|------------|------------|--------|----------|------------------|
| Bubble    | n        | n²         | n²         | ✅     | ✅       | O(1)             |
| Selection | n²       | n²         | n²         | ❌     | ✅       | O(1)             |
| Insertion | n        | n²         | n²         | ✅     | ✅       | O(1)             |
| Merge     | nlogn    | nlogn      | nlogn      | ✅     | ❌       | O(n)             |
| Quick     | nlogn    | nlogn      | n²         | ❌     | ✅       | O(log n)         |
| Heap      | nlogn    | nlogn      | nlogn      | ❌     | ✅       | O(1)             |
| Counting  | n + k    | n + k      | n + k      | ✅     | ❌       | O(k)             |
| Radix     | n        | n          | n          | ✅     | ❌       | O(n + k)         |
| Bucket    | n + k    | n + k      | n²         | ✅     | ⚠️       | O(n + k)         |
| Tim       | n        | nlogn      | nlogn      | ✅     | ❌       | O(n)             |

---

