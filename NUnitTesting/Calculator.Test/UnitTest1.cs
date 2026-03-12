using NUnit.Framework;
using Calculator.App;

namespace Calculator.Test;

[TestFixture]
public class Tests
{
    [Test]
    public void Sum_Test()
    {
        CalculatorClass c = new CalculatorClass();
        int result = c.Sum(2, 3);
        Assert.AreEqual(5, result);
    }
    [Test]
    public void Difference_Test()
    {
        CalculatorClass c = new CalculatorClass();
        int result = c.Difference(5, 3);
        Assert.AreEqual(2, result);
    }
    [Test]
    public void Multiply_Test()
    {
        CalculatorClass c = new CalculatorClass();
        int result = c.Multiply(2, 3);
        Assert.AreEqual(6, result);
    }
    [Test]
    public void Divide_Test()
    {
        CalculatorClass c = new CalculatorClass();
        int result = c.Divide(6, 3);
        Assert.AreEqual(2, result);
    }
}
