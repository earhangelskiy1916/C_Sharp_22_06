int FindSecond(int number)
{
    int NumNeed = number / 10;
    int NumSecond = NumNeed % 10;
    Console.WriteLine(NumSecond);
    return NumSecond;
}

int Num3Digit = new Random().Next(100, 1000);
Console.WriteLine(Num3Digit);
FindSecond(Num3Digit);
