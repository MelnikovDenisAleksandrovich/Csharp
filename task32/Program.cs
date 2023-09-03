/*
Напишите программу замена элементов массива: положительные элементы замените на
соответствующие отрецательные и на оборот.
[-4, -8, 8, -2] -> [4, 8, -8, 2]*/

Console.Clear();

int[] GetRandomArray(int arrayLength1, int start, int end)
{
    int[] array = new int[arrayLength1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
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

System.Console.WriteLine("Введите число ");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] userArray = (GetRandomArray(arrayL, min, max));
PrintArray(userArray);

int[] ChangeSignArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }

    return array;
}

PrintArray(ChangeSignArray(userArray));