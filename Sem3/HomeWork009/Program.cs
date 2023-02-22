int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Cube(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
    }
}

int N = ReadInt("Введите число: ");
Cube(N);
