string Bin(int a)
{
    string number = string.Empty;
    for(; a!=0; a/=2)
    {
        number = a%2+number;
    }
    return number;
}

Console.WriteLine("enter number");
int First = int.Parse(Console.ReadLine()!);

string BinResult =Bin(First);
Console.Write(BinResult);
