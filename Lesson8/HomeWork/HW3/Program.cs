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

int[,] Product(int[,] arr1, int[,] arr2)
{
    int raws1 = arr1.GetLength(0);
    int cols1 = arr1.GetLength(1);

    int raws2 = arr2.GetLength(0);
    int cols2 = arr2.GetLength(1);

    int[,] ProductMatrix = new int[raws1, cols1];
    if (cols1 != raws2)
    {
        return ProductMatrix;
    }
    else if (cols1 == raws2)
    {
        ProductMatrix = new int[raws1, cols2];
    }
    for (int i = 0; i < raws1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            for (int k = 0; k < cols1; k++)
            {
                ProductMatrix[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }

    return ProductMatrix;
}

Console.WriteLine("enter rows quantity");
int raws1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter columns quantity");
int columns1 = int.Parse(Console.ReadLine()!);
int[,] FirstArray = new int[raws1, columns1];

Console.WriteLine("enter rows quantity");
int raws2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter columns quantity");
int columns2 = int.Parse(Console.ReadLine()!);
int[,] SecondArray = new int[raws2, columns2];

FillArray(FirstArray);
PrintArray(FirstArray);

FillArray(SecondArray);
PrintArray(SecondArray);
Console.WriteLine();
int[,] Prod = Product(FirstArray, SecondArray);
PrintArray(Prod);
