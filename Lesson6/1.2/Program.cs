void Fib(int a)
{
    int temp1 = 0;
    int temp2 = 1;
    
    for (int i = 0; i < a; i++)
    {
        Console.WriteLine(temp1);
        (temp1, temp2) = (temp2, temp2+temp1);
    }
    
}

Console.WriteLine("enter number");
int First = int.Parse(Console.ReadLine()!);

Fib(First);
