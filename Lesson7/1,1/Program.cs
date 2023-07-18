void FillArray(int[,] Array)
{
   int rows = Array.GetLength(0);
   int cols = Array.GetLength(1);
   
    for (int i = 0; i < rows; i++)
    {
        
        for (int j = 0; j < cols; j++)
        {
            Array[i,j] = i+j;
        }
    }
}

void PrintArray(int[,] SomeArray)
{
    int y = SomeArray.GetLength(0);
    int x = SomeArray.GetLength(1);
   
    for (int i = 0; i < y; i++)
    {
        
        for (int j = 0; j < x; j++)
        {
           Console.Write(SomeArray[i,j]+"    ");
        }
        Console.WriteLine();
    }
}



Console.WriteLine("enter rows quantity");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter columns quantity");
int columns = int.Parse(Console.ReadLine()!);
int[,] MyArray = new int[rows,columns];
FillArray(MyArray);
PrintArray(MyArray);
