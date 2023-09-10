/*
52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

int[,] GetRandom2DArray(int rowNumber, int colNumber, int max, int min)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(max, min);
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)

{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] AvgEveryColsFrom2DArray(int[,] arrayForAvgEveryCols)
{
    double[] result = new double[arrayForAvgEveryCols.GetLength(1)];

    for (int i = 0; i < arrayForAvgEveryCols.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arrayForAvgEveryCols.GetLength(0); j++)
        {
            sum = sum + arrayForAvgEveryCols[j, i];
        }
        result[i] = sum / arrayForAvgEveryCols.GetLength(1);
    }
    return result;
}

void PrintArray(double[] arrayForPrint)
{
    Console.Write("[Avg]\t");
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write(Math.Round(arrayForPrint[1], 1));
        if (i < arrayForPrint.Length - 1) System.Console.Write("\t");
    }
}

int[,] userArray = GetRandom2DArray(5, 5, -10, 10);
double[] avgColsFromArray = AvgEveryColsFrom2DArray(userArray);
Print2DArray(userArray);
PrintArray(avgColsFromArray);

