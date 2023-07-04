long TurnOver(long Number)
{
    long NewNumber = 0;
    long LastNumber = 0;

    while (Number > 0)
    {
        LastNumber = Number % 10;
        Number = Number / 10;
        NewNumber = NewNumber * 10 + LastNumber;
    }

    return NewNumber;
}

Console.WriteLine("write number");
long UserNumber = long.Parse(Console.ReadLine()!);
long RevNumber = TurnOver(UserNumber);
if (UserNumber == RevNumber)
    Console.WriteLine("yes");
if (UserNumber != RevNumber)
    Console.WriteLine("no");
