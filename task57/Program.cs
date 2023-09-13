/*
57.Составте частотный словарь элементов двумерного массива.
Частотный словарь соддержит информацию о том, сколько раз встречаеться элемент входных данных.
*/
/*
Console.Clear();
int[,] Fill2DArray()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Введите количество строк в двумерном массиве ");
    int cols = Convert.ToInt32(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("Введите количество столбцов в двумерном массиве ");
    int rows = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[cols, rows];

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Введите максимальное значение ");
    int max = Convert.ToInt32(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Введите минимальное значение ");
    int min = Convert.ToInt32(Console.ReadLine());
int result = new int[cols, rows];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i, j] = new Random().Next() * (max - min) + (min);
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

int[] Convert2DArrayToArray(int[,] array2DConvert)
{
    int index = 0;
    int rows = array2DConvert.GetLength(0);
    int cols = array2DConvert.GetLength(1);
    int[] array = new int[rows * cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[index] = array2DConvert[i, j];
            index++;
        }
    }
    return array;
}


void PrintFrequencyVocabulary(int[] arrayForCountNumber)
{
    for (int number = 0; number < 10; number++)
    {
        int countNumber = 0;

        for (int i = 0; i < arrayForCountNumber.Length; i++)
        {
            if (number == arrayForCountNumber[i]) countNumber++;
        }
        if (countNumber != 0) Console.WriteLine($"Число {number} встречается {countNumber} раз");
    }
}

int[,] user2DArray = Fill2DArray();
int[] userArray = Convert2DArrayToArray(user2DArray);

Print2DArray(user2DArray);
Console.WriteLine();
PrintFrequencyVocabulary(userArray);
*/

Console.Clear();

/*
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

int[] ExpandMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0) * matrix.GetLength(1);
    int[] array = new int[n];

    n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[n] = matrix[i, j];
            n++;
        }
    }

    return array;
}

int[] CollectionSort(int[] array)

{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        if (i != minPosition)
        {
            int temp = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temp;
        }
    }
    return array;
}

void Count(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        int number = array[i];
        int count = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (number == array[j]) count++;
        }

        Console.WriteLine($"Число {number} встречается {count} раз");
    }
}

int[,] userArray = GetRandom2DArray(3, 4, 0, 10);
Print2DArray(userArray);
Console.WriteLine();
Count(CollectionSort(ExpandMatrix(userArray)));
*/

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = FillMatrixRnd(m, n);
PrintMatrix(arr);

int[] expandArray = ExpandMatrix(arr);
CollectionSort(expandArray);
//Console.WriteLine($"{String.Join(",", expandArray)}");
RepeatRate(expandArray);

//Заполнение массива случайными числами:
int[,] FillMatrixRnd(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

//Вывод двумерного массива:
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


// Разворот матрицы в одномерный массив:
int[] ExpandMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0) * matrix.GetLength(1);
    int[] array = new int[n];
    n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[n] = matrix[i, j];
            n++;
        }
    }
    return array;
}


// Сортировка элементов по возростанию:
void CollectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        if (i != minPosition)
        {
            int temp = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temp;
        }
    }
}


// Вывод количества повторений значение элемента массива:
void RepeatRate(int[] array)
{
    int save = array[0];
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == save)
            count++;
        else
        {
            Console.WriteLine($"{save} - {count} шт");
            save = array[i];
            count = 1;
        }
        if (i == array.Length - 1)
            Console.WriteLine($"{save} - {count} шт");
    }
}
