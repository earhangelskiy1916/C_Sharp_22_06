int NewNumber(int Num)
{
    int NewNumber2 = 0;

    if (Num > 999)
    {
        while (Num > 999)
        {
            Num = Num / 10;
            NewNumber2 = Num % 10;
        }
    }
    else if (Num > 99 & Num < 1000)
    {
        NewNumber2 = Num % 10;
    }
    else
    {
        Console.WriteLine("No third digit");
    }

    Console.WriteLine(NewNumber2);
    return NewNumber2;
}

int MyNumber = new Random().Next();
Console.WriteLine(MyNumber);
NewNumber(MyNumber);
