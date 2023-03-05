//int[,] intArray = new int[4, 4];
//Random rnd = new Random();
//int[][] n = Enumerable.Range(0, 4).Select(v => Enumerable.Range(0, 4).Select(c => rnd.Next(1, 10)).ToArray()).ToArray();
//Console.WriteLine($"Исходный массив:\n{String.Join("\n", n.Select(v => String.Join("\t", v)))}");
//int[] x = n[0]; n[0] = n[n.Length - 1]; n[n.Length - 1] = x;
//Console.WriteLine($"Преобразованный массив:\n{String.Join("\n", n.Select(v => String.Join("\t", v)))}");
//Console.ReadLine();
//
int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

int [,] SetArray2D (int line, int column)
{
    int [,] numArr2D = new int [line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            numArr2D [i, j] = new Random ().Next (0, 10);
        }
    }
    return numArr2D;
}

void PrintArray2D (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength (0); i++)
    {
        for (int j = 0; j < array2D.GetLength (1); j++)
        {
            Console.Write (array2D [i, j] + " ");
        }
        Console.WriteLine ();
    }
}

int [,] ChgArr2D (int [,] array2D)
{
    int [,] tempArr = new int [array2D.GetLength (0), array2D.GetLength (1)];
    int m = 0;
    int n = 0;

    for (int i = 0; i < array2D.GetLength (0); i++)
    {
        m++;
        for (int j = m; j < array2D.GetLength (0); j++)
        {
            tempArr [i, j] = array2D [i, j];
            array2D [i, j] = array2D [j, i];
        }
    }

    for (int i = 1; i < array2D.GetLength (0); i++)
    {
        n++;
        for (int j = 0; j < n; j++)
        {
            array2D [i, j] = tempArr [j, i];
        }
    }
    return array2D;
}

int m = InputNum ("Задайте кол-во строк: ");
int n = InputNum ("Задайте кол-во столбцов: ");

int [,] array = SetArray2D (m, n);

Console.WriteLine ($"Ваш массив {m} x {n}:");
PrintArray2D (array);

if (array.GetLength (0) != array.GetLength (1)) 
{
    Console.WriteLine ($"Для данного метода нужен квадратный массив");
}
else
{
    int [,] cngArray = ChgArr2D (array);

    Console.WriteLine ($"Измененный массив:");
    PrintArray2D (cngArray);
}