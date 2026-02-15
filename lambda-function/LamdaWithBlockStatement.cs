Func<int, int> CheckMethod = num =>
{
    if(num > 0) 
        return 1;
    else 
        return -1;
};

Console.WriteLine("Output : " + CheckMethod(25));
