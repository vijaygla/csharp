using System;

class LegacyAPI
{
    [Obsolete("OldFeature is deprecated. Use NewFeature instead.")]
    public void OldFeature()
    {
        Console.WriteLine("Old Feature");
    }

    public void NewFeature()
    {
        Console.WriteLine("New Feature");
    }
}

class Program
{
    static void Main()
    {
        LegacyAPI api = new LegacyAPI();
        api.OldFeature();   // Warning
        api.NewFeature();
    }
}
