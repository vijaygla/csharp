# Annotation(attribute in csharp)
- Annotation is called attribute in csharp.
- They are use to add the `metadata`(extra info) to classes, method, properties, etc.
- Metadata means information about code, not logic itself.

```csharp
[AttributeName(parameters)]
```

## Why we use the Attributes
- Validation
- Serialization
- ORM (Entity Framework)
- Unit Testing
- Custom behavior using Reflection

## Built-in Attribute Example
```csharp
using System;

class Demo
{
    [Obsolete("Use NewMethod instead")]
    public void OldMethod()
    {
        Console.WriteLine("Old Method");
    }
}
```
> Obsolete tells developers this method should not be used.

## Custom Attribute example
> Step 1 Create attribute
```csharp
using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class InfoAttribute : Attribute
{
    public string Author { get; }
    public int Version { get; }

    public InfoAttribute(string author, int version)
    {
        Author = author;
        Version = version;
    }
}
```
> Step 2 apply attribute
```csharp
[Info("Pmd", 1)]
class SampleClass
{
    [Info("Pmd", 2)]
    public void TestMethod()
    {
        Console.WriteLine("Hello");
    }
}
```
