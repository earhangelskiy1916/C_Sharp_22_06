int Sum(int M, int N)
{
    if (M == N + 1)
        return 0;
    else

        return M + Sum(M + 1, N);
}

Console.WriteLine("enter x");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter y");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int s = Sum(x, y);
Console.WriteLine(s);
