/*
65. Задайте значение M и N. Напишите программу, 
которая выдает все натуральные числа в промежутке от  M до N.
*/

Console.Clear();

void NuturalNum(int m, int n)
{
    if (m<= n)
    {
        Console.Write(m + ", ");
        NuturalNum(m + 1, n);
    }
}
NuturalNum(1,7);