

Console.WriteLine("write number");
string number = Console.ReadLine()!;
int num = int.Parse(number);
int count = 0;
if (num>0)
{
    while (count!=num*2+1)
    {
        
        Console.Write(count-num);
        count = count+1;
    }
}    
else
{
    while (count!=num*2-1)
    {
        Console.Write(count-num);
        count = count-1;
    }

}
    

