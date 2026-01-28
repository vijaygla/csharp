using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute : Attribute
{
    public string Priority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo("HIGH", "Alice")]
    public void CompleteTask() { }
}

class Program
{
    static void Main()
    {
        MethodInfo method = typeof(TaskManager).GetMethod("CompleteTask");
        TaskInfoAttribute attr = method.GetCustomAttribute<TaskInfoAttribute>();

        Console.WriteLine($"{attr.Priority}, {attr.AssignedTo}");
    }
}
