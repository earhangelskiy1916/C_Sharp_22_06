void Point()
{
    Console.WriteLine("enter b1");
    double b1 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("enter b2");
    double b2 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("enter k1");
    double k1 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("enter k2");
    double k2 = double.Parse(Console.ReadLine()!);

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine(x);
    Console.WriteLine(y);
}
Point();
