//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
void Average(int[,] matr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < matr.GetLength(1); i++)
{
double sum = 0;
    for (int j =0; j < matr.GetLength(0); j++)
    {
        sum += matr[j, i];
    }
    double average = sum / matr.GetLength(0);
            Console.Write($"{average:f1}; ");
}
}

int[,] matrix = new int [3, 4];  
FillArray(matrix);
PrintArray(matrix);
Average(matrix);