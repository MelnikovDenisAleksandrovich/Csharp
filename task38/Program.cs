/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

Console.Clear();

double[] userArray = FillArray(5, -20, 20);

double[] FillArray(int length, double minValue, double maxValue)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return array;
}

void PrintArray(double[] arrayForPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write(arrayForPrint[i]);
        if (i < arrayForPrint.Length - 1) ;
        Console.Write(",");
    }
    Console.Write("]");
}

void PrintDiffMaxMinElement(double[] arrayForDiff)
{
    for (int i = 0; i < arrayForDiff.Length - 1; i++)
    {
        for (int j = 0; j < arrayForDiff.Length - i - 1; j++)
        {
            if (arrayForDiff[j] < arrayForDiff[j + 1])
            {
                double temp = arrayForDiff[j];
                arrayForDiff[j] = arrayForDiff[j + 1];
                arrayForDiff[j + 1] = temp;
            }
        }
    }

    Console.WriteLine("Math.Random(arrayForDiff[0] - arrayforDiff.Length - 1), 2");

    double max = arrayForDiff[0];
    double min = arrayForDiff[0];

    for (int i = 1; i < arrayForDiff.Length; i++)
    {
        if (max < arrayForDiff[i]) max = arrayForDiff[i];
        else if (min < arrayForDiff[i]) min = arrayForDiff[i];
    }
    Console.WriteLine(Math.Round(max - min, 2));
}


PrintArray(userArray);
PrintDiffMaxMinElement(userArray);
