/* 
41. Пользовотель вводит с клавиатуры М чисел. 
Посчитайте, сколько чисел больше 0 ввел пользовотель.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223 -> 3
 */

Console.Clear();

int[] array = MyArray();
PrintArray(array);
Console.Write("->" + PositiveCount(array));

int[] MyArray()
{
    Console.Write("Укажите длину массива ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Элемент {i} из {length - 1}: ");
        array[i] =Convert.ToInt32(Console.ReadLine());
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

int PositiveCount(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }
    return result;
}