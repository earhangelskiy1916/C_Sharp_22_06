// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("write two nubmers");
string numberA = Console.ReadLine()!;
string numberB = Console.ReadLine()!;
int numA = int.Parse(numberA);
int numB = int.Parse(numberB);
if(numA>numB)
{
    Console.WriteLine(numA);
}
if(numA<numB)
{
    Console.WriteLine(numB);
}
if(numA==numB)
{
    Console.WriteLine("equal");
}