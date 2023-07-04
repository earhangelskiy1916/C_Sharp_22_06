void Quarters (int Num)
{
    if (Num > 4)
        Console.WriteLine ("error ");
    else if (Num == 1)
        Console.WriteLine ("X>0 && Y>0");
    else if (Num == 2)
        Console.WriteLine ("X<0 && Y>0");
    else if (Num == 3)
        Console.WriteLine ("IX<0 && Y<0");
    else if (Num == 4)
        Console.WriteLine ("X>0 && Y<0");
}

int A = int.Parse(Console.ReadLine()!);


Quarters(A);
