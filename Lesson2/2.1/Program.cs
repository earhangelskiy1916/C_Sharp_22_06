int MaxDigit (int Number)
{
    int FirstDigit = 0;
    int SecondDigit = 0;
    int Max = 0;

    FirstDigit = Number/10;
    SecondDigit = Number%10;
    if(FirstDigit>SecondDigit)
    {
        Max = FirstDigit;
    }
    else if(FirstDigit<SecondDigit)
    {
        Max = SecondDigit;
    }
    else if(FirstDigit==SecondDigit)
    {
        Console.WriteLine("digits are equal");
    }
    Console.WriteLine(Number);
    Console.WriteLine(Max);
    return Max;

}

int NewNumber = new Random().Next(10,99);
MaxDigit(NewNumber);

