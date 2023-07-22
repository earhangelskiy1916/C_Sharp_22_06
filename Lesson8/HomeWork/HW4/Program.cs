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

int[] SmallArray(int[,] Matrix)
{
    int raws = Matrix.GetLength(0);
    int cols = Matrix.GetLength(1);
    int minnum = Matrix[0, 0];

    int[] minind = new int[2];
    for (int i = 0; i < raws; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (Matrix[i, j] < minnum)
            {
                minnum = Matrix[i, j];
                minind[0] = i;
                minind[1] = j;
            }
        }
    }
    return minind;
}

void NewArray(int[,] bigArray, int[] littleArray)
{
    int y = bigArray.GetLength(0);
    int x = bigArray.GetLength(1);
    for (int p = 0; p < y; p++)
    {
        for (int q = 0; q < x; q++)
        {
            if (p == littleArray[0] || q == littleArray[1])
            {
                continue;
            }
            else
            {
                Console.Write("   " + bigArray[p, q]);
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("enter rows quantity");
int raws = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter columns quantity");
int columns = int.Parse(Console.ReadLine()!);
int[,] MyArray = new int[raws, columns];
FillArray(MyArray);
PrintArray(MyArray);
int[] MinArray = SmallArray(MyArray);
Console.WriteLine();
NewArray(MyArray, MinArray);
