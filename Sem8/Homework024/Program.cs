void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} ");
            }
            Console.WriteLine();
        }
    }
}
void FillArray(int[,,] matr)
{
    int count = 10;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] += count;
                count += 3;
            }
        }
    }
}
void PrintIndex(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k})");
            }
        }
    }
}
int[,,] matrix = new int[2, 2, 2];
FillArray(matrix);
PrintArray(matrix);
PrintIndex(matrix);