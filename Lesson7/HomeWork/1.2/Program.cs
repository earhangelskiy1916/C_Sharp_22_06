void FillArray(int[,] Array)
{
    Console.WriteLine("enter start range");
    int StartRange = int.Parse(Console.ReadLine()!);
    Console.WriteLine("enter stop range");
    int StopRange = int.Parse(Console.ReadLine()!);

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

string FindNum(int[,] TheArray, int positionY, int positionX)
{
    int AxisY = TheArray.GetLength(0);
    int AxisX = TheArray.GetLength(0);
    if (AxisY < positionY || AxisX < positionX)
    {
        return "Not found";
    }
    else
    {
        for (int y = 0; y < AxisY; y++)
        {
            for (int x = 0; x < AxisX; x++)
            {
                if (TheArray[y, x] == TheArray[positionY - 1, positionX - 1])
                {
                    return $"[{TheArray[y, x]}]";
                }
            }
        }
    }
    return "";
}

Console.WriteLine("enter rows quantity");
int raws = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter columns quantity");
int columns = int.Parse(Console.ReadLine()!);
int[,] MyArray = new int[raws, columns];
FillArray(MyArray);
PrintArray(MyArray);
Console.WriteLine("enter y position");
int positionInraws = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter x position");
int positionInColumns = int.Parse(Console.ReadLine()!);
string find = FindNum(MyArray, positionInraws, positionInColumns);
Console.WriteLine(find);
