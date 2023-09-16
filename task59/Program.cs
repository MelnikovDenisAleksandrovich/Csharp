/*
59. Задайте двумерный массив из целых из целых чисел.
Напишите программу, которая удалит строку и столбец, на пересечение которых 
расположен наименьший элемент массива.  
*/

Console.Clear();
/*
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
    Console.Write("Введите максимальное значение ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Введите минимальное значение ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    int[,] result = new int[cols, rows];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result[i, j] = new Random().Next(min,max)
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
            System.Console.Write(arrayToPrint[i, j]);
        }
        System.Console.WriteLine();
    }
}

int[] CoordsMinValue(int[,] arrayForFindMinValue)
{
    int minValue = arrayForFindMinValue[0, 0];
    int[] coords = new int[2];

    for (int i = 0; i < arrayForFindMinValue.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForFindMinValue.GetLength(1); j++)
        {
            if (arrayForFindMinValue[i, j] < minValue)
            {
                minValue = arrayForFindMinValue[i, j];
                coords[0] = i;
                coords[1] = j;
            }
        }
    }

    return coords;
}


int[,] DeleteRowAndCol(int[,] arrayForDelete)
{
    int rows = arrayForDelete.GetLength(0);
    int cols = arrayForDelete.GetLength(1);
    int[] coords = CoordsMinValue(arrayForDelete);
    int delRow = coords[0];
    int delCol = coords[1];

    int[] array = new int[(rows - 1) * (cols - 1)];
    int index = 0;

    // Заполнение одномерный массив без удаленных значений.

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (i != delRow && j != delCol)
            {
                array[index] = arrayForDelete[i, j];
                index++;
            }
        }
    }

    // Востанавливаем двумерный массив, но уже без удаленной строки и столбца.

    int[,] result = new int[rows - 1, cols - 1];
    index = 0;

    for (int i = 0; i < rows - 1; i++)
    {
        for (int j = 0; j < cols -1; j++)
        {
            result[i, j] = array[index];
        }
    }
    return result;
}

int[,] userArray = Fill2DArray();
Print2DArray(userArray);
Console.WriteLine();
Print2DArray(DeleteRowAndCol(userArray));
*/


int[,] Get2DArray(int row, int col, int max, int min)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(max, min);
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

int[] CoordsMinValue(int[,] array)
{
    int[] result = new int[2];
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

int[,] FillZero(int[,] array)
{
    int[] coords = CoordsMinValue(array);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[coords[0], i] = 0;
    }
    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[i, coords[1]] = 0;
    }
    return array;
}
int[,] DeleteCross(int[,] array)
{
    int rows = array.GetLength(0) - 1;
    int cols = array.GetLength(1) - 1;
    int[,] result = new int[rows, cols];

    for (int row = 0; row < rows + 1; row++)
    {
        for (int col = 0; col < cols + 1; col++)
        {
            if (array[row, col] != 0)
            { 
                result[row, col] = array[row, col];
            }
        }
    }
    return result;
}

int[,] arr = Get2DArray(7, 7, 1, 10);
Print2DArray(arr);

Console.WriteLine();

int[,] arr2 = FillZero(arr);
Print2DArray(arr2);

Console.WriteLine();

int[,] arr3 = DeleteCross(arr2);
Print2DArray(arr3);