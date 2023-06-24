//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("write three nubmers");
string numberA = Console.ReadLine()!;
string numberB = Console.ReadLine()!;
string numberC = Console.ReadLine()!;
int numA = int.Parse(numberA);
int numB = int.Parse(numberB);
int numC = int.Parse(numberC);
int Max = numA;
if(numB>Max)
{
    Max = numB;
}
if(numC>Max)
{
    Max = numC;
}
Console.WriteLine(Max);