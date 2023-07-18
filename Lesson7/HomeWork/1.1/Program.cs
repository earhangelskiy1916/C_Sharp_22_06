void FillArray(double[,]Array)
{
    Console.WriteLine("enter range start");
    int StartRange = int.Parse(Console.ReadLine()!);
    Console.WriteLine("enter range end");
    int StopRange = int.Parse(Console.ReadLine()!);
    int raw = Array.GetLength(0);
    int col = Array.GetLength(1);
    Random rand = new();
    
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < col; j++)
        {
            
            Array[i,j] = StartRange + rand.NextDouble() * (StopRange - StartRange);
            Array[i,j] = Math.Round(Array[i,j],2);
        }
    }
    
}

void PrintArray(double[,] SomeArray)
{
    int y = SomeArray.GetLength(0);
    int x = SomeArray.GetLength(1);
    for (int s = 0; s < y; s++)
    {
        for (int d = 0; d < x; d++)
        {
            Console.Write($"{SomeArray[s,d]}    ");
        }
        Console.WriteLine();
    }
    
}

Console.WriteLine("enter rows quantity");
int raws = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter columns quantity");
int columns = int.Parse(Console.ReadLine()!);
double[,] MyArray = new double[raws, columns];
FillArray(MyArray);
PrintArray(MyArray);
