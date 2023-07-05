
// int[] NewArray = new int [8];
// (new Random().Next(1,10));

void Array (int[] NewArray)
{
    for (int i = 0; i < NewArray.Length; i++)
    {
        NewArray[i] = new Random().Next(0,2);
    }
}

void List (int[] NewList)
{
    for (int j = 0; j < NewList.Length; j++)
    {
        Console.Write(NewList[j] + " ");
    }
}
int[] MyArray = new int[8];

Array(MyArray);
List(MyArray);

