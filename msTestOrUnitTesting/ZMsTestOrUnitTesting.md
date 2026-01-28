# MSTest(Unit Testing)
- MSTest is Microsoft’s unit testing framework used to test individual methods/classes in isolation.
- It is provided by the dotnet framework.

## Why MSTest?
- Detect bugs early
- Validate business logic
- Improve code quality
- Required for SonarQube test coverage

## MSTest Key Attributes
```csharp
[TestClass]   // Marks a test class
[TestMethod]  // Marks a test method
[TestInitialize] // Runs before each test
[TestCleanup]    // Runs after each test
[ExpectedException(typeof(ExceptionType))]
```
```
[TestClass]
public class CalculatorTests
{
    Calculator calc;

    [TestInitialize]
    public void Setup()
    {
        calc = new Calculator();
    }

    [TestMethod]
    public void Add_TwoNumbers_ReturnsSum()
    {
        int result = calc.Add(10, 5);
        Assert.AreEqual(15, result);
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void Divide_ByZero_ThrowsException()
    {
        calc.Divide(10, 0);
    }
}
```
>MSTest validates business logic and improves maintainability.


## NUnit vs MSTest (Comparison)

| Feature | NUnit | MSTest |
|------|-------|--------|
| Developed by | Open-source community | Microsoft |
| Framework type | Unit testing framework | Unit testing framework |
| Popularity | Very popular, widely used | Official Microsoft framework |
| Attributes | `[TestFixture]`, `[Test]` | `[TestClass]`, `[TestMethod]` |
| Setup method | `[SetUp]` | `[TestInitialize]` |
| Cleanup method | `[TearDown]` | `[TestCleanup]` |
| One-time setup | `[OneTimeSetUp]` | `[ClassInitialize]` |
| One-time cleanup | `[OneTimeTearDown]` | `[ClassCleanup]` |
| Parameterized tests | `[TestCase]` | `[DataTestMethod]`, `[DataRow]` |
| Expected exception | `Assert.Throws<T>()` | `[ExpectedException]` |
| Assertion support | Rich & fluent assertions | Basic assertions |
| Test execution | Works with most test runners | Best with Visual Studio |
| .NET support | .NET Framework / .NET Core | .NET Framework / .NET Core |
| Extensibility | Highly extensible | Limited compared to NUnit |
| Ease of use | More flexible | Simpler, beginner-friendly |
| Best use case | Advanced testing scenarios | Enterprise / Microsoft-centric apps |

# 