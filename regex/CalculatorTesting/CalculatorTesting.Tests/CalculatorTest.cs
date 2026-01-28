using NUnit.Framework;
using CalculatorTesting.Core;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calc;

    [SetUp]
    public void Setup() => _calc = new Calculator();

    [Test]
    public void Add_ReturnsCorrectSum()
        => Assert.That(_calc.Add(2, 3), Is.EqualTo(5));

    [Test]
    public void Divide_ByZero_ThrowsException()
        => Assert.Throws<DivideByZeroException>(() => _calc.Divide(10, 0));
}
