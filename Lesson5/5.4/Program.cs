int[] FillArray(int[] Array)
{
    Console.WriteLine("enter start range");
    int StartRange = int.Parse(Console.ReadLine()!);
    Console.WriteLine("enter stop range");
    int StopRange = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(StartRange, StopRange);
    }
    return Array;
}

int[] NewArray(int[] arr)
{
    int Length = arr.Length;
    int[] arr_2;

    if (Length % 2 == 0)
        arr_2 = new int[Length / 2];
    else
        arr_2 = new int[Length / 2 + 1];
    for (int i = 0; i < arr_2.Length; i++)
    {
        if (arr[i] != arr[Length - i - 1])
            arr_2[i] = arr[i] * arr[Length - i - 1];
        else
            arr_2[arr_2.Length - 1] = arr[i];
    }
    return arr_2;
}

void PrintArray(int[] LiberArray)
{
    Console.WriteLine(string.Join(" ", LiberArray));
}

Console.WriteLine("Enter length");
int length = int.Parse(Console.ReadLine()!);
int[] MyArray = new int[length];

FillArray(MyArray);
int[] ShortArray = NewArray(MyArray);
PrintArray(ShortArray);
