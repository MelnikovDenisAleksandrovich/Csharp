/*
67. Напишите программу, которая будет принимать на вход число и возращать сумму его цифр.
*/ 

Console.Clear();

int result = SumNumber(256);

int SumNumber(int n)
{
    if (n == 0)
    return  0;
    else
    return n%10 + SumNumber(n/10); 
}
Console.WriteLine($"Сумма цифер числа N: {result}");