int FillArray(int[] Array)
{
    Console.WriteLine("enter start range");
    int StartRange = int.Parse(Console.ReadLine()!);
    Console.WriteLine("enter stop range");
    int StopRange = int.Parse(Console.ReadLine()!);
    int count = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(StartRange, StopRange);
        if (i % 2 == 0)
        {
            count = count + Array[i];
        }
    }
    Console.WriteLine(string.Join(",", Array));

    return count;
}

Console.WriteLine("enter length");
int length = int.Parse(Console.ReadLine()!);
int[] MyArray = new int[length];
int target = FillArray(MyArray);
Console.WriteLine(target);
