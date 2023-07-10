int A = int.Parse(Console.ReadLine()!);

int Count(int Number)
{
    int result = 0;
    for (int i = 1; A > 0; i++)
    {
        A = A / 10;
        result = i;
    }
    return result;
}

Console.WriteLine(Count(A));
