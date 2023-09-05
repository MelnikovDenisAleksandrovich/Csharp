/*
Задайте массив заполняющий случайными положительными трехзначными числами, 
Напишите программу, которая покажет количество четных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Clear();

int[] FillArray()
{
Console.Write("Введите трехзначное число ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenght];
for(int i = 0; i < lenght; i++)
{
    array[i] = new Random().Next(100, 1000);
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

void PrintEvenCountInArray(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if(item%2==0) count++;
    }
    Console.WriteLine($"{count} четных чисел в массиве");
}

int[] userArray = FillArray();

PrintArray(userArray);
PrintEvenCountInArray(userArray);