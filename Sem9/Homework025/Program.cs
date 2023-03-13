Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int b = 1;
string NumbersFor (int N, int b)
{
    string result = String.Empty;
    for (int i = N; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec (int N, int b)
{
    if (N <= b) return NumbersRec(N + 1, b) + $"{N} ";
    else return String.Empty;
}

Console.WriteLine(NumbersFor(N, b));
Console.WriteLine(NumbersRec(N, b));
