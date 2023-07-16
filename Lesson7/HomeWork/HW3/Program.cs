void FillArray(int[,] Array)
{
    Console.WriteLine("enter start range");
    int StartRange = int.Parse(Console.ReadLine()!);
    Console.WriteLine("enter stop range");
    int StopRange = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    int raw = Array.GetLength(0);
    int column = Array.GetLength(1);
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Array[i, j] = new Random().Next(StartRange, StopRange);
        }
    }
}

void PrintArray(int[,] SomeArray)
{
    int y = SomeArray.GetLength(0);
    int x = SomeArray.GetLength(1);
    for (int n = 0; n < y; n++)
    {
        for (int m = 0; m < x; m++)
        {
            Console.Write(SomeArray[n, m] + "    ");
        }
        Console.WriteLine();
    }
}

void Average(int[,] turnedArray)
{
    int height = turnedArray.GetLength(0);
    int width = turnedArray.GetLength(1);
    double sum = 0;
    for (int e = 0; e < width; e++)
    {
        for (int r = 0; r < height; r++)
        {
            sum = sum + turnedArray[r, e];
        }

        Console.Write(Math.Round(sum / height, 1) + "   ");
        sum = 0;
    }
}

Console.WriteLine("enter rows quantity");
int raws = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter columns quantity");
int columns = int.Parse(Console.ReadLine()!);
int[,] MyArray = new int[raws, columns];
FillArray(MyArray);
PrintArray(MyArray);
Console.WriteLine();
Average(MyArray);
