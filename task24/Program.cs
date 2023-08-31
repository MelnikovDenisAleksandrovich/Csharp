/*Напишите программу, которая принимает на вход число (А)
и выдает сумму чисел от 1 до А.*/

Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());

/*
int sum = 0;
for(int i = 1; i<= userNumber; i++)
{
    sum += i;
}
Console.WriteLine(sum);
*/

int SunOfNumber(int number)
{
    int sum = 0;
for(int i = 1; i<= userNumber; i++)
{
    sum += i;
}
    return sum;
}

Console.WriteLine($"Сумма цифр в числе {userNumber} равна {SunOfNumber(userNumber)}");