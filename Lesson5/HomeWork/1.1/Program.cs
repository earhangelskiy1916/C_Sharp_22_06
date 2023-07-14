int FillArray(int[] Array)
{
    
    Console.WriteLine("enter start range");
    int StartRange = int.Parse(Console.ReadLine()!);
    Console.WriteLine("enter stop range");
    int StopRange = int.Parse(Console.ReadLine()!);
    int count = 0;

    for (int i = 0; i < Array.Length-1; i++)
    {
        Array[i] = new Random().Next(StartRange,StopRange);
        if((Array[i]) % 2==0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
    return count;
    
}


Console.WriteLine("enter length");
int length = int.Parse(Console.ReadLine()!);
int[] MyArray = new int[length];
FillArray(MyArray);
