int IfDayOff(int DayNumber)
{
    if (DayNumber == 1 || DayNumber == 2 || DayNumber == 3 || DayNumber == 4 || DayNumber == 5)
    {
        Console.WriteLine("no");
    }
    else if (DayNumber == 6 || DayNumber == 7)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("Wrong day number");
    }
    return DayNumber;
}
Console.WriteLine("Enter day number");
int MyDay = int.Parse(Console.ReadLine()!);
IfDayOff(MyDay);
