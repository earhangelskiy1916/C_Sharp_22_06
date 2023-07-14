void FillArray(int[,] Array)
{
    Console.WriteLine("enter start range");
    int StartRange = int.Parse(Console.ReadLine()!);
    Console.WriteLine("enter stop range");
    int StopRange = int.Parse(Console.ReadLine()!);
    for (int yi = 0; yi < Array.GetLength(0); yi++)
    {
        for (int xi = 0; xi < Array.GetLength(1); xi++)
        {
            Array[yi, xi] = new Random().Next(StartRange, StopRange);
        }
    }
}

int[,] CopyArray(int[,] SomeArray)
{
    int rows = SomeArray.GetLength(0);
    int columns = SomeArray.GetLength(1);
    int[,] NewArray;
    NewArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            NewArray[i, j] = SomeArray[i, j];
        }
    }
    return NewArray;
}

void PrintArray(int[,] YourArray)
{
    for (int h = 0; h < YourArray.GetLength(0); h++)
    {
        for (int g = 0; g < YourArray.GetLength(1); g++)
        {
            Console.Write(YourArray[h, g] + "   ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("enter rows quantity");
int rQuant = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter columns quantity");
int cQuant = int.Parse(Console.ReadLine()!);
int[,] MyArray = new int[rQuant, cQuant];

FillArray(MyArray);
CopyArray(MyArray);
PrintArray(MyArray);
