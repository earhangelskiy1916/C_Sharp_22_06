// 1. Напишите программу, которая на вход принимает два числа и проверяет,
//    является ли первое число квадратом второго.
Console.WriteLine("Write two numbers");
string numberA = Console. ReadLine()!;
string numberB = Console.ReadLine()!;
int numA = int.Parse(numberA);
int numB = int.Parse(numberB);
if (numA*numA==numB)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
