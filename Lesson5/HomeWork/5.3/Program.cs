double MaxMinusMin(double[] Array)
{
    double max = Array[0];
    double min = Array[0];

    for (int i = 0; i < Array.Length - 1; i++)
    {
        if (Array[i + 1] > max)
        {
            max = Array[i + 1];
        }

        if (Array[i + 1] < min)
        {
            min = Array[i + 1];
        }
        double result = max - min;
    }

    double aim = max - min;
    return aim;
}

double[] MyArray = { 3.22, 4.2, 1.15, 77.15, 65.2 };

double result = MaxMinusMin(MyArray);
Console.WriteLine(result);
