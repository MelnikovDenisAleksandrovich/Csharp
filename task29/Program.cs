/*Напишите программу, которая задает массив из
8 элементов и выводит их на экран.

1,2,5,7,19 -> [1,2,5,7,19]
6,1,33 ->[6,1,33] */

int[] GetRandomArray()
{
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);

}
return array;
}

int[] userArray = GetRandomArray();

void PrintArray(int[] arrayToPrint)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        System.Console.Write($"{arrayToPrint[i]} ");
    }
    System.Console.WriteLine("]");
}

PrintArray(userArray);