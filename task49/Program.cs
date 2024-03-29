﻿/*
49. Задайте двузмерный массив. Найдите элементы, у которых оба индекса четных
и замените на их квадраты 
*/

Console.Clear();

int[,] GetRandom2DArray(int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation);
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


int[,] DoobleEven2DArray(int [,]array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[,] result = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if(i%2 == 0 && j%2 == 0) result[i, j] = array[i, j] * array[i, j];
            else result [i, j] = array[i, j];
        }
    }
    return result;
}


int[,] arr = GetRandom2DArray(5, 5, 10);
Print2DArray(arr);
Console.WriteLine("");
int[,] newArr = DoobleEven2DArray(arr);
Print2DArray(newArr);