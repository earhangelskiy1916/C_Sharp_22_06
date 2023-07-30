int Exp(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }

    return Exp(a, b - 1) * a;
}

int x = 2;
int y = 4;
int exp = Exp(x, y);
Console.WriteLine(exp);
