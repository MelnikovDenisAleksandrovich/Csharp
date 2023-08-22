/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("Введите Число N: ");

int numberN = Convert.ToInt32(Console.ReadLine());
double result = 0;

for (int i = 1; i <= numberN; i++)
{
    result = Math.Pow(i, 3);
    Console.WriteLine(result);
}
