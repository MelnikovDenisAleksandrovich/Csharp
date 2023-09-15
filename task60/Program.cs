/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.Clear();

int[,,] FillUniqRandom3DArray()
{
    Console.Write("Введите кол-во столбцов: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите глубину массива: ");
    int deep = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[rows, cols, deep];
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    if (maxValue - minValue < rows * cols * deep) Console.WriteLine("массив не может быть заполнен без повторений");
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int m = 0; m < array.GetLength(2); m++)
                {
                    bool norepeat;
                    int randomValue = 0;
                    do
                    {
                        norepeat = false;
                        randomValue = new Random().Next(minValue, maxValue);
                        foreach (var item in array)
                        {
                            if (item == randomValue) norepeat = true;
                        }
                    }while (norepeat);
                    array[i, j, m] = randomValue;
                }
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            for (int m = 0; m < arrayForPrint.GetLength(2); m++)
            {
                Console.WriteLine($"array[{i}, {j}, {m}] = {arrayForPrint[i, j, m]}");
            }
        }
    }
}

int[,,] userArray = FillUniqRandom3DArray();
Print3DArray(userArray);