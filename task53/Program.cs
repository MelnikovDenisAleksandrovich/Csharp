/*
53. Задайте двумерный массив, Напишите программу, которая поменяет местами первую 
и последнию строку масива.
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2 
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

int[,] ResultArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int temp = 0;

    for (int i = 0; i < cols; i++)
    {
        temp = array[0, i];
        array[0, i] = array[rows - 1, i];
        array[rows - 1, i] = temp;
    }
    return array;
}

int[,] arr = GetRandom2DArray(4, 4, 0, 10);
Print2DArray(arr);
Console.WriteLine();
int[,] arr2 = ResultArray(arr);
Print2DArray(arr2);


/*
Разобраться позже что не так !!!


int[,] Fill2DArray()
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
    int maxValue = Convert.ToInt32(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Введите минимальное значение ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    
    double[,] array = new double[cols, rows];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
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
            System.Console.Write(Math.Round(arrayToPrint[i, j], 2) + "\t");
        }
        System.Console.WriteLine();
    }
}
Второй метод : 
int[,] SwapFirstWitnLastRowsInArray(int[,] arrayForSwap)
{
    int[] temp = new int[arrayForSwap.GetLength(1)];
    for (int i = 0; i < arrayForSwap.GetLength(1); i++)
    {
        temp[i] = arrayForSwap[0, 1];
    }
    for (int i = 0; i < arrayForSwap.GetLength(1); i++)
    {
        arrayForSwap[0, i] = arrayForSwap[arrayForSwap.GetLength(0) - 1, i];
    }
    for (int i = 0; i < arrayForSwap.GetLength(1); i++)
    {
        arrayForSwap[arrayForSwap.GetLength(0) - 1, i] = temp[i];
    }
    return arrayForSwap;
}

/*int[] SwapFirstWitnLastRowsInArrayWithoutTemp(int[,] arrayForSwap)

{
    int row = arrayForSwap.GetLength(0);

    for (int j = 0; j < arrayForSwap.GetLength(1); j++)
    {
        arrayForSwap[0, j] = arrayForSwap[0, j] + arrayForSwap[row - 1, j];
        arrayForSwap[row - 1, j] = arrayForSwap[0, j] - arrayForSwap[row - 1, j];
        arrayForSwap[0, j] = arrayForSwap[0, j] - arrayForSwap[row - 1, j];
    }

    return arrayForSwap;
}*/

/*
int[,] userArray = Fill2DArray();
Print2DArray(userArray);
Console.WriteLine();
Print2DArray(SwapFirstWitnLastRowsInArray(userArray));
Console.WriteLine();
//Print2DArray(SwapFirstWitnLastRowsInArrayWithoutTemp(userArray));
*/