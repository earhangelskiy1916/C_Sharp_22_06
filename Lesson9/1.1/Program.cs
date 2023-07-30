void PrintNum (int num)
{
    if (num == 0)
    {
        return;
    }
    PrintNum(num-1);
    Console.Write(num);
}
PrintNum(5);