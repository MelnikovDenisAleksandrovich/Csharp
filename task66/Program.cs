/*
 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
 натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

Console.WriteLine("Введите  число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите  число M:");
int numberN = int.Parse(Console.ReadLine());

///Метод нахождения суммы натуральных элементов в промежутке от M до N
void NaturalNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    NaturalNumberSum(numberM, numberN, sum);
}

NaturalNumberSum(numberM, numberN, 0);