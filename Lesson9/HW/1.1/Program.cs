void EvenNums(int M, int N)
{
    if (M >= N)
        return;

    if (M % 2 == 0)
    {
        Console.WriteLine(M);
        EvenNums(M + 2, N);
    }
    else
    {
        M = M + 1;
        Console.WriteLine(M);
        EvenNums(M + 1, N);
    }
}

Console.WriteLine("enter x");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter y");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine();
EvenNums(x, y);
