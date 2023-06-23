// 2. Напишите программу, которая будет выдавать название дня
//    недели по заданному номеру.
Console.WriteLine("Write number");
string num = Console.ReadLine()!;
int day = int.Parse(num);
if(day == 1)
{
    Console.WriteLine("monday");
}
else if(day==2)
{
    Console.WriteLine("tuesday");
}
else if(day==3)
{
    Console.WriteLine("wednesday");
}
else if(day==4)
{
    Console.WriteLine("thursday");
}
else if(day==5)
{
    Console.WriteLine("frieday");
}
else if(day==6)
{
    Console.WriteLine("saturday");
}
else if(day==7)
{
    Console.WriteLine("sunday");
}
else
{
    Console.WriteLine("wrong day");
}
