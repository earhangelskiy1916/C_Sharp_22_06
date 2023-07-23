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

int[] OneDArray(int[,] arr)
{
    int raw = arr.GetLength(0);
    int column = arr.GetLength(1);
    // int count = 0;
    int[] arr2 = new int[raw * column];
    int index = 0;
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr2[index] = arr[i, j];
            index++;
        }
    }

    return arr2;
}

void PrintNewArray(int[] SomeNewArray)
{
    int y = SomeNewArray.Length;

    for (int m = 0; m < y; m++)
    {
        Console.Write(SomeNewArray[m] + "    ");
    }
}

int[] NewCount(int[] arr3)
{
    int[] friq= new int [arr3.Length+1];
    
    foreach (int i in arr3)
    {
        friq[i] +=1;
    }
    return friq;
    
    
}

Console.WriteLine("enter rows quantity");
int raws = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter columns quantity");
int columns = int.Parse(Console.ReadLine()!);
int[,] MyArray = new int[raws, columns];
FillArray(MyArray);
Console.WriteLine();
PrintArray(MyArray);
int[] WowArray = OneDArray(MyArray);
Console.WriteLine();
PrintNewArray(WowArray);
Console.WriteLine();
int[] lalala = NewCount(WowArray);
Console.WriteLine(string.Join("   ", lalala));
