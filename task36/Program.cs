/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();

int[] userArray = FillArray(5, 0, 11);
int[] FillArray(int lenght, int minValue, int maxValue)
{
    int[] array = new int[lenght];

    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(maxValue, maxValue);
    }
    return array;
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

void PrintSumOddElements(int[] arrayforSum)
{
    int sumOdd = 0;

    for (int i = 1; i < arrayforSum.Length; i += 2)
    {
        sumOdd += arrayforSum[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях ={sumOdd}");
}
PrintArray(userArray);
PrintSumOddElements(userArray);
