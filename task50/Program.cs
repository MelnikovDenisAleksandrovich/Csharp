/*
50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

void PrintElementFrom2DArray(int[,] array)
{
    Console.WriteLine("Введите позицию элемента: ");
    Console.Write("Строка ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.Write("Столбец ");
    int col = Convert.ToInt32(Console.ReadLine());

    if (line < array.GetLength(0) && col < array.GetLength(1)) Console.WriteLine(array[line, col]);
    else Console.WriteLine("Нет такого элемента");
}

void PrintFindNumberFrom2DArray(int[,] array2DForFindNumber)
{
    Console.Write("Введите искомое число: ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    bool checkNumber = true;

    for (int i = 0; i < array2DForFindNumber.GetLength(0); i++)
    {
        for (int j = 0; j < array2DForFindNumber.GetLength(1); j++)
        {
            if (array2DForFindNumber[i, j] == userNumber)
            {
                Console.WriteLine($"Число {userNumber} находится на {i} строке, {j} столбце");
                checkNumber = true;
            }
        }
    }
    if (checkNumber) Console.WriteLine($"Числа {userNumber} нет в массиве");
}

int[,] arr = GetRandom2DArray(5, 5, -10, 10);
Print2DArray(arr);
PrintElementFrom2DArray(arr);
PrintFindNumberFrom2DArray(arr);
