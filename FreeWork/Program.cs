using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int x;
        int y;
        
        x = (int) inputValue();
        y = (int) Math.Pow(x, 2);
        Console.WriteLine(y);
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
