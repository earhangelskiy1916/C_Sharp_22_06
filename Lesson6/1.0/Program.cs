
void triangle(int a, int b , int c)
{
    if (a+b>c&& a+c>b&& b+c>a)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}

Console.WriteLine("enter three numbers");
int First = int.Parse(Console.ReadLine()!);
int Second = int.Parse(Console.ReadLine()!);
int Third = int.Parse(Console.ReadLine()!);

triangle(First,Second,Third);
