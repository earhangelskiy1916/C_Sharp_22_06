//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//число%2, если 0 -четное, если 1 - нечетное

Console.WriteLine("write nubmer");
string numberA = Console.ReadLine()!;
int numA = int.Parse(numberA);
if(numA%2 == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
