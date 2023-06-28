int IfMult (int Number)
{   
    int NumberA = 0;

    if(Number%7==0 & Number%23==0 )
    {
        NumberA = Number;
        
        Console.WriteLine("yes");
    }
    else
    {
        NumberA = Number;
        
        Console.WriteLine("no");
    }
    return NumberA;
}

Console.WriteLine("Enter number");
int MyNumber = int.Parse(Console.ReadLine()!);
IfMult(MyNumber);