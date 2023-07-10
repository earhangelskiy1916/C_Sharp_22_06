

Console.WriteLine("enter array length");
int length = int.Parse(Console.ReadLine()!);
int[] MyArray = new int[length];



void Array (int[] NewArray)
{
    Console.WriteLine("enter start range");
    int StartRange = int.Parse(Console.ReadLine()!);
    Console.WriteLine("enter stop range");
    int StopRange = int.Parse(Console.ReadLine()!);
    for (int i = 0; i < length; i++)
    {
        NewArray[i] = new Random().Next(StartRange,StopRange);
    }
}

void List (int[] NewList)
{
    for (int j = 0; j < NewList.Length; j++)
    {
        Console.Write(NewList[j] + " ");
    }
}


Array(MyArray);
List(MyArray);