# 📘 Streams in C# – Complete Notes

## 🔹 Definition of Stream

In C#, a **Stream** is an abstract base class used to read data from or write data to a source such as:

- Files
- Memory
- Network sockets
- Pipes

**A stream is simply a sequence of bytes flowing from a source to a destination.**

> 📌 **Streams deal with bytes, not characters.**

**Namespace:** `System.IO`  
**Base Class: ** `System.IO.Stream`

## 🔹 Why Streams Are Needed

-To handle large data efficiently
- To work with different data sources using the same API
- To support sequential access
- To enable buffering, seeking, and asynchronous I/O

## 🔹 Main Concepts of Streams

### 1️⃣ Byte-Based
- Streams work with bytes (`byte[]`)
-Text handling requires Reader/Writer classes

### 2️⃣ Sequential Access
- Data is read in order
- You can move the cursor using `Seek()` (if supported)

### 3️⃣ Read / Write Capability
    -Some streams are read-only, write-only, or both

### 4️⃣ Buffered Operations
- Improves performance by reducing direct I/O calls

### 5️⃣ Stream Chaining
Streams can be wrapped inside other streams

**Example:**
`FileStream → BufferedStream → StreamReader`
## 🔹 Stream Class Properties

| Property | Description |
| -----------| ------------------------------|
| `CanRead` | Checks if stream supports reading |
| `CanWrite`| Checks if stream supports writing |
| `CanSeek` | Checks if stream supports seeking |
| `Length`  | Total size of stream         |
| `Position`| Current cursor position      |

## 🔹 Stream Class Methods

| Method   | Purpose             |
|----------|---------------------|
| `Read()` | Read bytes from stream |
| `Write()`| Write bytes to stream |
| `Seek()` | Move cursor          |
| `Flush()`| Clear buffer         |
| `Close()`| Close stream         |
| `Dispose()`| Release resources  |

## 🔹 Types of Streams in C#

### 🔸 1. FileStream
**Used to read/write files.**

**Namespace:** `System.IO`

**Syntax:**
```csharp
FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate);
```
```
using System.IO;

FileStream fs = new FileStream("test.txt", FileMode.Create);
byte[] data = { 65, 66, 67 };
fs.Write(data, 0, data.Length);
fs.Close();
```
## 🔸 2. MemoryStream
**Stores data in memory (RAM).**

**Syntax:**
```csharp
MemoryStream ms = new MemoryStream();
MemoryStream ms = new MemoryStream();
ms.WriteByte(100);
byte[] arr = ms.ToArray();
```
### 🔸 3. BufferedStream

Adds a **buffer layer** to improve performance.

#### Syntax

```csharp
BufferedStream bs = new BufferedStream(stream);
FileStream fs = new FileStream("file.txt", FileMode.Open);
BufferedStream bs = new BufferedStream(fs);
```
### 🔸 4. NetworkStream

Used for **network communication**.

#### Namespace

```csharp
System.Net.Sockets
NetworkStream ns = tcpClient.GetStream();
```
### 🔸 5. PipeStream (C#) `using System.IO.Pipes;`
`PipeStream` is an abstract base class in **System.IO.Pipes** used for **inter-process communication (IPC)**.  
It enables data exchange between processes using **named pipes** or **anonymous pipes**.

Derived classes:
- `NamedPipeServerStream`
- `NamedPipeClientStream`
- `AnonymousPipeServerStream`
- `AnonymousPipeClientStream`

---
