// 4. Напишите программу вычисления модуля числа.
Console.WriteLine("write number");
string number = Console.ReadLine()!;
int absolute = int.Parse(number);
if(absolute<0)
{
    absolute = absolute*-1;
}
Console.WriteLine(absolute);
