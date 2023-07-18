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

string FindNum(int[,] TheArray, int num)
{
    int AxisY = TheArray.GetLength(0);
    int AxisX = TheArray.GetLength(0);

    for (int y = 0; y < AxisY; y++)
    {
        for (int x = 0; x < AxisX; x++)
        {
            if (TheArray[y, x] == num)
            {
                y = y + 1;
                x = x + 1;
                Console.WriteLine(y);
                Console.WriteLine(x);
                return $"[{y + 1},{x + 1}]";
            }
        }
    }
    return "Not Found";
}

Console.WriteLine("enter rows quantity");
int raws = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter columns quantity");
int columns = int.Parse(Console.ReadLine()!);
int[,] MyArray = new int[raws, columns];
FillArray(MyArray);
PrintArray(MyArray);
Console.WriteLine("enter number");
int aim = int.Parse(Console.ReadLine()!);
string find = FindNum(MyArray, aim);
Console.WriteLine(find);
FindNum(MyArray, aim);
