/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();
int[,] Fill2DArrayA()
{
    Console.Write("Введите количество столбцов в двумерном массиве A ");
    int cols = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество строк в двумерном массиве A ");
    int rows = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[cols, rows];

    Console.Write("Введите минимальное значение A ");
    int min = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите максимальное значение A ");
    int max = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

int[,] Fill2DArrayB(int rows)
{
    Console.Write("Введите количество столбцов в двумерном массиве B ");
    int cols = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[cols, rows];

    Console.Write("Введите минимальное значение B ");
    int min = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите максимальное значение B ");
    int max = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
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

int[,] ProductArrays(int[,] arrayForProductA, int[,] arrayForProductB)
{
    int rowsA = arrayForProductA.GetLength(0);
    int colsA = arrayForProductA.GetLength(1);
    int rowsB = arrayForProductB.GetLength(0);
    int colsB = arrayForProductB.GetLength(1);
    int[,] result = new int[rowsA, colsB];
    int productElements = 1;

    for (int i = 0; i < rowsA; i++)
    {
        for (int m = 0; m < colsB; m++)
        {
            for (int j = 0; j < colsA; j++)
            {
                for (int n = 0; n < rowsB; n++)
                {
                    productElements = arrayForProductA[i, n] * arrayForProductB[n, j];
                    result[i, j] += productElements;
                }
            }
        }
    }
    return result;
}


int[,] arrayA = Fill2DArrayA();
int rows = arrayA.GetLength(1);
int[,] arrayB = Fill2DArrayB(rows);
int[,] productArrays = ProductArrays(arrayA, arrayB);

Print2DArray(arrayA);
Console.WriteLine();
Print2DArray(arrayB);
Console.WriteLine();
Print2DArray(productArrays);