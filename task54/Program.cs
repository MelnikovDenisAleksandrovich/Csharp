/*
54.Задайте двумерный массив, Напишите программу, которая упорядочит по 
убыванию элементы каждой строки двумерного массива. 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

int[,] SortDecreaseRowsInArray(int[,] arrayForSort)
{
    bool sorted;

    do
    {
        sorted = false;
        for (int i = 0; i < arrayForSort.GetLength(0); i++)
        {
            for (int j = 1; j < arrayForSort.GetLength(1); j++)
            {
                if (arrayForSort[i, j - 1] < arrayForSort[i, j])
                {
                    int temp = arrayForSort[i, j - 1];
                    arrayForSort[i, j - 1] = arrayForSort[i, j];
                    arrayForSort[i, j] = temp;
                    sorted = true;
                }
            }
        }
    } while (sorted);

    return arrayForSort;
}


int[,] userArray = GetRandom2DArray(4, 4, 0, 10);
Print2DArray(userArray);
Console.WriteLine();
Print2DArray(SortDecreaseRowsInArray(userArray));