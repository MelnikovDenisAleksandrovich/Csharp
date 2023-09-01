/*Напишите программу, которая принимает на вход число N и 
выдает произвидение чисел от 1 до N.

4 -> 24
5 -> 120
*/

System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int ProductOfNumber(int number)
{
    int product = 1;
for (int i = 1; i <= userNumber; i++)
{
    product *= i;
}
return product;
}

System.Console.WriteLine($"Произведение в числе {userNumber} равна {ProductOfNumber(userNumber)}");