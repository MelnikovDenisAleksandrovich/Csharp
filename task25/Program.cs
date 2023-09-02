/*Напишите цикл,который принимает на вход 
два числа (А и В) и возводит число А в 
натуральную степень В.

3,5 -> 243(3..5)
2,4 -> 16
*/

Console.WriteLine("Введите числа A и B ");
int numberA =Convert.ToInt32(Console.ReadLine());
int numberB =Convert.ToInt32(Console.ReadLine());

int ProductOfNumbers(int a, int b)
{
    int product = 1;
    for (int i = 1; i <= b; i++)
    {
        product = product*a;
    }
    return product;
}

Console.WriteLine($"число {numberA} в степени {numberB} равно {ProductOfNumbers(numberA,numberB)}");
