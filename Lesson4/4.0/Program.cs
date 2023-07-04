Console.WriteLine("write number");
int Number = int.Parse(Console.ReadLine()!);
int LastDigit = 0;
int Sum(int AnyNumber)
{
    int sum = 0;
    for (int i = 0; Number>0; i++)
    {
        LastDigit = Number%10;
        sum = sum+LastDigit;
        Number = Number-1;
    }
    return sum;
}
Console.WriteLine(Sum(Number));
