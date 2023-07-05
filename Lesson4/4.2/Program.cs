void Mult()
{
    int Number = int.Parse(Console.ReadLine()!);
    int LastDigit = 0;
    int multiplication = 1;
    for (int i = 0; Number != 0; i++)
    {
        LastDigit = Number % 10;
        multiplication = multiplication * LastDigit;
        Number = Number - 1;
    }

    Console.WriteLine(multiplication);
}
Console.WriteLine("write number");
Mult();
