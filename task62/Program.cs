/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.Clear();
/*
int[,] FillSpirally2DArray()
{
    Console.Write("Введите кол-во столбцов ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во строк ");
    int rows = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, cols];
    int value = 1;
    // Создадим границы, которые будем сужать.
    int left = 0, right = cols - 1, top = 0, bottom = rows - 1;

    while (left <= right && top <= bottom)
    {
        // Заполнение верхней строки.
        for (int i = left; i <= right; i++)
            array[top, i] = value++;
        // Заполнение правого столбца.
        for (int j = top + 1; j <= bottom; j++)
            array[j, right] = value++;
        // Заполнение нижней строки.
        if (top < bottom)
        {
            for (int i = right - 1; i >= left; i--)
                array[bottom, i] = value++;
        }
        // Заполнение левого столбца.
        if (left < right)
        {
            for (int i = bottom - 1; i > top; i--)
                array[i, left] = value++;
        }

        left++;
        right--;
        top++;
        bottom--;
    }
    return array;
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

Print2DArray(FillSpirally2DArray());
*/


// Второй метод:

Console.Write("Высота массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Ширина массива ");
int cols = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int[,] array = Spiral(rows, cols);

int[,] Spiral(int rows, int cols)
{
    int[,] array = new int[rows, cols];                // Создаем пустой массив заданного размера.
    int end = rows * cols;                             // до какого числа заполняем спираль.
    int right = cols - 1;                              // правая граница.
    int bottom = rows - 1;                             // нижняя граница.
    int left = 0;                                      // левая граница.
    int top = 1;                                       // верхняя граница.
    int direction = 1;                                 // начальное направление спирали (1 - вправо, 2 - вниз, 3 - влево, 4 - вверх).
    int y = 0;                                             // начальные кординаты спирали. 
    int x = 0;
    int pause = 200;                                         // величина паузы (мс)

    for (int i = 1; i <= end; i++)
    {
        array[y, x] = i;                               // заполняем ячейку.
        PrintCurrent(array, y, x);                     // отрисовываем текущее состояние массива. 
        Thread.Sleep(pause);                           // задержка перед следущей итерацией.

        if (direction == 1 && x < right) x++;          // идем право, пока не упремся в границу.
        else if (direction == 1 && x == right)         // если уперлись в правую границу.
        {
            direction = 2;                             // меняем направление в низ.
            right--;                                   // и сдвигаем правую границу.
        }
        if (direction == 2 && y < bottom) y++;         // идем вниз, пока не упремся в границу.
        else if (direction == 2 && y == bottom)        // если уперлись в нижнию границу.
        {
            direction = 3;                             // меняем направление налево. 
            bottom--;                                  // и сдигаем нижнию границу.
        }
        if (direction == 3 && x > left) x--;           // идем влево, пока не упремся в границу.
        else if (direction == 3 && x == left)            // если уперлись в левую границу.
        {
            direction = 4;                            // меняем направление вверх.
            left++;                                   // и сдвигаем левую границу.
        }
        if (direction == 4 && y > top) y--;           // идем вверх, пока не упремся в границу.
        else if (direction == 4 && y == top)          // если уперлись в верхнюю границу.
        {
            direction = 1;                            // меняем направление вправо.
            top++;                                    // сдвигаем верхнюю границу.
            x++;                                      // и текущию позицию.
        }
    }
    return array;
}

void PrintCurrent(int[,] array, int y, int x)                        // передаем массив и кординаторы текущего значение.
{
    Console.SetCursorPosition(0,0);                                  // ставим курсор в начальную позицию.
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == x && i == y)                                   // рисуем текущию позицию красным цветом.
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(array[i, j] + "\t");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (array[i, j] != 0)                               // уже отрисованные позиции желтым. 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(array[i, j] + "\t");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else                                                      //пустые (нулевые) черным.
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(array[i, j] + "\t");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        Console.WriteLine();
    }
}