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
    
    // .NET может считывать только отдельные символы или целые строки из консоли
//. Следующая функция безопасно считывает двойное значение.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
