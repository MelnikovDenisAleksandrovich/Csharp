/*
69. Напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень В с помощью рекурсии.
*/

Console.Clear();

int result = ProdNumber(2, 4);

int ProdNumber(int n, int m)
{
    if (m == 1)
    return  n;
    else
    return n * ProdNumber(n, m - 1); 
}
Console.WriteLine($"Число А в целой степени В: {result}");
