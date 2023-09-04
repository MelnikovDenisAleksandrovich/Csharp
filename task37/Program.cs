/*Найдите произведение пар чисел в одномерном массиве. Парой считаем первым
и последним элемент, второй и предпоследний и т. д.
Результат запишите в новом массиве. 
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] ->36 21
*/

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

int ProdPar(int[] array)
{
    int[] array1 = new int[(array.Length)/2];

    for(int i = 0; i <array.Length/2; i++)
    {
        array1[i] = array[i]*array[array.Length-i-1];

    }
    return array1;
}

System.Console.WriteLine("Введите число ");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(arrayL, max, min);
Console.WriteLine();
PrintArray(userArray);
int[] newArray = ProdPar(userArray);
PrintArray(newArray);