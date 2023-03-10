void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
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
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
void minRowSum(int[,] matr)
{
    int index = 0;
    int minRowSum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            rowSum += matr[i, j];
        }
        if (i == 0)
        {
            minRowSum = rowSum;
        }
        else if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            index = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов {index}. ");
}
int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);
minRowSum(matrix);
