using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description { get; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

class App
{
    [BugReport("Null reference issue")]
    [BugReport("Performance issue")]
    public void Process() { }
}

class Program
{
    static void Main()
    {
        MethodInfo method = typeof(App).GetMethod("Process");
        var bugs = method.GetCustomAttributes<BugReportAttribute>();

        foreach (var bug in bugs)
        {
            Console.WriteLine(bug.Description);
        }
    }
}
