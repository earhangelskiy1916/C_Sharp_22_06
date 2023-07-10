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
        if (Array[i] > 9 && Array[i] < 100)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Enter length");
int length = int.Parse(Console.ReadLine()!);
int[] NewArray = new int[length];

int quantity = FillArray(NewArray);
Console.WriteLine(quantity);
