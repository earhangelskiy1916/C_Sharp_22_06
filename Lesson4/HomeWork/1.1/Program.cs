void PrintA (int num1, int num2)
{
    int num3=num1;
    for (int i = 1; i < num2; i++)
    {
        num1 = num1*num3;
    }
    Console.WriteLine(num1);
}

Console.WriteLine("Enter two numbers");
int X = int.Parse(Console.ReadLine()!);
int Y = int.Parse(Console.ReadLine()!);


PrintA(X,Y);
