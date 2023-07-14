int[] Array(int ArrayLength)
{
    int[] Array2 = new int[ArrayLength];
    for (int i = 0; i < Array2.Length; i++)
    {
        Console.WriteLine("enter number");
        Array2[i] = int.Parse(Console.ReadLine()!);
    }
    return Array2;
}

void PrintArray(int[] SomeArray)
{
    for (int j = 0; j < SomeArray.Length; j++)
    {
        Console.WriteLine(SomeArray[j]);
    }
}

int PositiveDigits(int[] YourArray)
{
    int count = 0;

    for (int h = 0; h < YourArray.Length; h++)
    {
        if (YourArray[h] > 0)
        {
            count++;
        }
    }

    return count;
}

Console.WriteLine("enter length");
int length = int.Parse(Console.ReadLine()!);
int[] MyArray = Array(length);
PrintArray(MyArray);
int PositiveCount = PositiveDigits(MyArray);
Console.WriteLine("quantity of positve numbers is " + PositiveCount);
