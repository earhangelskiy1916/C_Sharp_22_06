int NumSum(int num)
{
    if (num / 10 == 0)
    {
        return num;
    }

    return NumSum(num / 10) + num % 10;
}

int sum = NumSum(333);
Console.WriteLine(sum);
