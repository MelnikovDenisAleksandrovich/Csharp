/*
63. Задайте значение N. Напишите программу, которая выдает все натуральные
числа в промежутке от 1 до N.
*/

Console.Clear();

void NuturalNum(int n, int start = 1)
{
    if (start <= n)
    {
        Console.Write(start + ", ");
        NuturalNum(n, start + 1);
    }
}
NuturalNum(5);