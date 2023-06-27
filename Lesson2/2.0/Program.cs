int LastNumber (int Number)
{
    int NewNumber = 0;
    NewNumber = Number%10;
    Console.WriteLine(NewNumber);
    return NewNumber;
}

int MyNumber = new Random().Next(100,1000);
Console.WriteLine(MyNumber);
LastNumber(MyNumber);