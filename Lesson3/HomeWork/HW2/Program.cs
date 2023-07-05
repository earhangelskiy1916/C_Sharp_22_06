double Destination3D(int x1, int y1, int x2, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow(x1 - y1, 2) + Math.Pow(x2 - y2, 2) + Math.Pow(z1 - z2, 2));
}

Console.WriteLine("isert coordinates");
int Ax = int.Parse(Console.ReadLine()!);
int Ay = int.Parse(Console.ReadLine()!);
int Az = int.Parse(Console.ReadLine()!);
int Bx = int.Parse(Console.ReadLine()!);
int By = int.Parse(Console.ReadLine()!);
int Bz = int.Parse(Console.ReadLine()!);

double result = Destination3D(Ax, Bx, Ay, By, Az, Bz);
Console.WriteLine(result);
