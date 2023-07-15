// int[,] FillArray (int[,] Array)
// {
//     int row = Array.GetLength(0);
//     int col = Array.GetLength(1);
//     Console.WriteLine("enter start range");
//     int StartRange = int.Parse(Console.ReadLine()!);
//     Console.WriteLine("enter stop range");
//     int StopRange = int.Parse(Console.ReadLine()!);

//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             Array[i,j]= new Random().Next(StartRange,StopRange);
//             Console.Write(Array[i,j]+ "    ");
//         }
//         Console.WriteLine();
//     }
//     return Array;
// }

// int[,] ChangeArray (int[,] TheArray)
// {
//     for (int h = 0; h < TheArray.GetLength(0); h++)
//     {
//         for (int k = 0; k < TheArray.GetLength(1); k++)
//         {
//             if(h%2==1 && k%2==1)
//             {
//                 TheArray[h,k] = TheArray[h,k]*TheArray[h,k];
//             }
//         }
//     }
//     return TheArray;
// }

// void PrintArray(int[,] SomeArray)
// {
//     int y = SomeArray.GetLength(0);
//     int x = SomeArray.GetLength(1);
//     for (int s = 0; s < y; s++)
//     {
//         for (int d = 0; d < x; d++)
//         {
//             Console.Write($"{SomeArray[s,d]}    ");
//         }
//         Console.WriteLine();
//     }
    
// }

// Console.WriteLine("enter rows quantity");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("enter columns quantity");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] MyArray = new int[rows,columns];


// FillArray(MyArray);
// ChangeArray(MyArray);
// Console.WriteLine();
// PrintArray(MyArray);
Random rand = new();
double min = 15.1;
double max = 28.2;
 
double x = min + rand.NextDouble() * (max - min);
Console.WriteLine(x);