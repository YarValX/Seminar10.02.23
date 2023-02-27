
int[] myArray = new int[4];
Random rand = new Random();
for (int x = 0; x < myArray.Length; x++)
      {
          myArray[x] = rand.Next(100, 999);
          Console.WriteLine(myArray[x]);
      }

int count = 0;

for (int x = 0; x < myArray.Length; x++)
{
   if (myArray[x]%2==0)
   count++;
}
Console.WriteLine($"из {myArray.Length} чисел, {count} четных");

void PrintEven(int[] myArray)
{
    Console.Write("[ ");
        for(int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
}
   
