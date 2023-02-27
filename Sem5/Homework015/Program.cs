int[] myArray = new int[4];
int sumElements = 0;
Random rand = new Random();
for (int x = 0; x < myArray.Length; x++)
{
    myArray[x] = rand.Next(0, 99);
    Console.WriteLine(myArray[x] + " ");

    if (x % 2 == 1)
    {
        sumElements += myArray[x];
    }
}

Console.WriteLine($"всего из {myArray.Length} чисел, сумма элементов на нечётных позициях = {sumElements}");