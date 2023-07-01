// Напишите программу, которая принимает на вход координаты точки (X, Y), при чем x !=0 или y != 0 и выдает номер плоскости, в которой находится эта точка.



void Quarters (int X, int Y)
{
    if (X==0 || Y ==0)
        Console.WriteLine ("x=0 or y=0 ");
    else if (X>0 && Y>0)
        Console.WriteLine ("I quarter");
    else if (X<0 && Y>0)
        Console.WriteLine ("II quarter");
    else if (X<0 && Y<0)
        Console.WriteLine ("III quarter");
    else if (X>0 && Y<0)
        Console.WriteLine ("IV quarter");
}

int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);

Quarters(A,B);