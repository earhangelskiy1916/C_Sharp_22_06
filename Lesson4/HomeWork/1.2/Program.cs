void Sum(int Number)
{
    int sum = 0;
    for (int i = 0; Number > 0; i++)
    {
        int LastNumber = Number % 10;
        sum = sum + LastNumber;
        Number = Number / 10;
    }
    Console.WriteLine(sum);
}
Console.WriteLine("write number");
int Value = int.Parse(Console.ReadLine()!);
Sum(Value);
