/*Напишите программу,которая принимает на вход 
число и выдает сумму цифр в числе 

452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число");
int userNumber =Convert.ToInt32(Console.ReadLine());

int SumOfNumber(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}

Console.WriteLine($"Сумма чисел числа {userNumber} равна {SumOfNumber(userNumber)}");