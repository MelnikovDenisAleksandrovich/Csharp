/*
39. Напишите программу, которая перевернет одномерный масив 
(последний элемент на первом месте, а первый на последнем и т. д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
Коментарий эту задачу можно решить 2 способами 
1) менять числа местами в исходном  массиве;
2)Создать новый массив и в него записать перевернутый исходный 
массив по элементам.
*/

Console.Clear();

int[] userArray = GetRandomArray(6, 0, 11);

int[] GetRandomArray( int length, int maxValue, int minValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(maxValue, minValue);
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

int[] TurnArray(int[] arrayToTurn)
{
    int temp = 0;
    for (int i = 0; i < arrayToTurn.Length / 2; i++)
    {
        temp = arrayToTurn[i];
        arrayToTurn[i] = arrayToTurn[arrayToTurn.Length - 1 - i];
        arrayToTurn[arrayToTurn.Length - 1 - i] = temp;
    }
    return arrayToTurn;
}

Console.ForegroundColor = ConsoleColor.Blue;
PrintArray(userArray);
int[] turnArray = TurnArray(userArray);
Console.ForegroundColor = ConsoleColor.DarkGray;
PrintArray(turnArray);
Console.ForegroundColor = ConsoleColor.White;