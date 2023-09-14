/*
Задача 56: Задайте прямоугольный двумерный массив.
 Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

int[,] Fill2DArray()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Введите количество строк в двумерном массиве ");
    int cols = Convert.ToInt32(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("Введите количество столбцов в двумерном массиве ");
    int rows = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[cols, rows];

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Введите минимальное значение ");
    int min = Convert.ToInt32(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Введите максимальное значение ");
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

int[] SumRowsIn2DAraaya(int[,]array)
{
    int[] sumRows = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRows[i] += array[i, j];
        }
    }
    return sumRows;
}

void PrintArray(int[] arrayToPrint)

{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

void PrintSmallestElement(int[] array)
{
    int smallestSum = array[0];
    int rowFrom2DArray = 0; // Номер элемента будет соответствовать строке в двумерном массиве.

    for (int i = 1; i < array.Length; i++)
    {
        if (smallestSum > array[i])
        {
            smallestSum = array[i];
            rowFrom2DArray = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов будет в {rowFrom2DArray} в строке и она равна {smallestSum}");
}

int[,] userArray = Fill2DArray();
int[] sumRowsArray = SumRowsIn2DAraaya(userArray);

Print2DArray(userArray);
Console.WriteLine();
PrintArray(sumRowsArray);
Console.WriteLine();
PrintSmallestElement(sumRowsArray);
