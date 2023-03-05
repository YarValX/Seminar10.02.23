int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[,] matr)
{
for (int i=0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

void ArrayValue(int[,] matr, int rows, int colums)
{
    if (rows < matr.GetLength(0) && colums < matr.GetLength(1)) Console.WriteLine(matr[rows, colums]);
    else Console.WriteLine($"{rows},{colums} -> такого элемента в массиве нет");
}


int rows = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца: ");
int[,] matrix = new int [3, 4];  
FillArray(matrix);
PrintArray(matrix);
ArrayValue(matrix,rows, colums);

