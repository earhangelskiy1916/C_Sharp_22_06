void FillArray(int[] Array)
{
    int pos = 0;
    int neg = 0;
    Console.WriteLine("enter start range");
    int StartRange = int.Parse(Console.ReadLine()!);
    Console.WriteLine("enter stop range");

    int StopRange = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(StartRange, StopRange);
        if (Array[i] < 0)
        {
            neg = neg + Array[i];
        }
        if (Array[i] > 0)
        {
            pos = pos + Array[i];
        }
    }
    Console.WriteLine(pos);
    Console.WriteLine(neg);
}

Console.WriteLine("array length is");
int length = int.Parse(Console.ReadLine()!);
int[] UserArray = new int[length];

FillArray(UserArray);
