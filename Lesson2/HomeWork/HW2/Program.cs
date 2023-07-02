int FindNumber(int number)
{
    int NumFirst = number / 100;
    int NumThird = number % 10;
    int NumNeaded = NumFirst * 10 + NumThird;
    Console.WriteLine(NumNeaded);
    return NumNeaded;
}

int Num3Digit = new Random().Next(100, 1000);
Console.WriteLine(Num3Digit);
FindNumber(Num3Digit);