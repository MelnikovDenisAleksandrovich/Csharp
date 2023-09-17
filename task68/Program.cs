/*
68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

int Akermana(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0 && n > 0)
    {
        return Akermana(n - 1, 1);
    }
    else
    {
    return Akermana(n - 1, Akermana(n, m - 1));
    }
}




