//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("write nubmer");
string numberA = Console.ReadLine()!;
int numA = int.Parse(numberA);
int N = 0;
while(N<numA)
{
    N=N+1;
    if(N%2==0)
    {
        Console.WriteLine(N);
    }
    
}

