int[] FillArray(int[] Array)
{
    Console.WriteLine("enter start range");
    int StartRange = int.Parse(Console.ReadLine()!);
    Console.WriteLine("enter stop range");
    int StopRange = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(StartRange, StopRange);
        Console.WriteLine(+Array[i]);

        Array[i] = Array[i] * -1;
    }
    return Array;
}
Console.WriteLine("Enter length");
int length = int.Parse(Console.ReadLine()!);
int[] NewArray = new int[length];
FillArray(NewArray);
Console.WriteLine(string.Join(" ", NewArray));
