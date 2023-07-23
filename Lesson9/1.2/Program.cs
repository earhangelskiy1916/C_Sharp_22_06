void PrintNums(int M, int N)
{
    if (M > N)
        return;

    Console.Write(M);
    PrintNums(M + 1, N);
}
PrintNums(4, 8);
