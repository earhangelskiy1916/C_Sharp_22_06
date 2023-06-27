int Mult( int Num1, int Num2)
{
    int Result = 0;
    
    if(Num1%Num2 == 0 )
    {
        Console.Write(Num1);
        Console.Write(",");
        Console.Write(Num2);
        Console.Write(",");
        Console.Write("Yes");
    }
    else 
    {
        Result = Num1%Num2;
        Console.Write(Num1);
        Console.Write(",");
        Console.Write(Num2); 
        Console.Write(",");
        Console.Write("No, remnant=");
        Console.Write(Result);
    }
    return Result;
}

Console.WriteLine("Enter two numbers");
int MyNumber1 = int.Parse(Console.ReadLine());
int MyNumber2 = int.Parse(Console.ReadLine());
Mult(MyNumber1, MyNumber2);

