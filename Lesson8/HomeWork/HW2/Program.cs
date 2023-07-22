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

int[] RankArray(int[,] arr)
{
    int raw = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[] ArrayMinMax = new int[raw];

    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < column; j++)
        {
            ArrayMinMax[i] += arr[i, j];
        }
    }
    return ArrayMinMax;
}

int MinNum(int[] OneDArray)
{
    int length = OneDArray.Length;
    int min = 0;
    for (int i = 0; i < length; i++)
    {
        if (OneDArray[i] < OneDArray[min])
        {
            min = i;
        }
    }
    return min;
}

Console.WriteLine("enter rows quantity");
int raws = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter columns quantity");
int columns = int.Parse(Console.ReadLine()!);
int[,] MyArray = new int[raws, columns];
FillArray(MyArray);
PrintArray(MyArray);
int[] RArray = RankArray(MyArray);
Console.WriteLine(string.Join(" ", RArray));
int minNum = MinNum(RArray);
Console.WriteLine("string with minimal elements sum is " + (minNum + 1));
