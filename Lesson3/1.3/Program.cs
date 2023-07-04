double Cube (double Number)
{
    double NewNumber =0;

    if(Number>0)
    {
        while (Number>0)
        {
            NewNumber = Math.Pow(Number,2);
        
            Console.WriteLine(NewNumber);
            Number--;
        }
        
    }
    if(Number<0)
    {
        while (Number<0)
        {
            NewNumber = Math.Pow(Number,2);
        
            Console.WriteLine(NewNumber);
            Number++;
        }
    
    }
    return NewNumber;
}
int MyNumber = int.Parse(Console.ReadLine()!);
Cube(MyNumber);
