void FillArray(int[] Array, int Target)
{
    Console.WriteLine("enter start range");
    int StartRange = int.Parse(Console.ReadLine()!);
    Console.WriteLine("enter stop range");
    int StopRange = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(StartRange, StopRange);
        if (Array[i] == Target)
        {
            Console.WriteLine("yes");
            break;
        }
    }
}
Console.WriteLine("Enter length");
int length = int.Parse(Console.ReadLine()!);
int[] NewArray = new int[length];
Console.WriteLine("enter target");
int target = int.Parse(Console.ReadLine()!);
FillArray(NewArray, target);
