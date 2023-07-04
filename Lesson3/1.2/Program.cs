double Destination2D (int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x1-y1,2)+Math.Pow(x2-y2,2));
     
}

int Ax = int.Parse(Console.ReadLine())!;
int Ay = int.Parse(Console.ReadLine())!;

int Bx = int.Parse(Console.ReadLine())!;
int By = int.Parse(Console.ReadLine())!;


double result = Destination2D(Ax,Bx,Ay,By);
Console.WriteLine(result);
