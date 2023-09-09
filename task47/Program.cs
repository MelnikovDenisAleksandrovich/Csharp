/* 
47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Clear();

double[,] Fill2DArray()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Введите количество строк в двумерном массиве ");
    int cols = Convert.ToInt32(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("Введите количество столбцов в двумерном массиве ");
    int rows = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[cols, rows];

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Введите максимальное значение ");
    int max = Convert.ToInt32(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Введите минимальное значение ");
    int min = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * (max - min) + (min);
        }
    }
    return array;
}

void Print2DArray(double[,] arrayToPrint)
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
            System.Console.Write(Math.Round(arrayToPrint[i, j], 2) + "\t");
        }
        System.Console.WriteLine();
    }
}


Console.ForegroundColor = ConsoleColor.Blue;
Print2DArray(Fill2DArray());
