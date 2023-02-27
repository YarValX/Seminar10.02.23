double[] myArray = new double[6];
Random rand = new Random();
for (int x = 0; x < myArray.Length; x++)
      {
          myArray[x] = rand.Next(1, 99);
          Console.WriteLine(myArray[x] + "");
      }
double minArray = myArray[0];
double maxArray = myArray[0];
for (int x =1; x < myArray.Length; x++)
{
    if (minArray > myArray[x])
    {
        minArray = myArray[x];
    }
    if (maxArray < myArray[x])
    {
        maxArray = myArray[x];
    }
}
double decision = maxArray - minArray;
Console.WriteLine($"разница между между максимальным ({maxArray}) и минимальным({minArray}) элементами: {decision}");