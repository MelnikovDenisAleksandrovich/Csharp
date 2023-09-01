/*напишите программу,которая принимает на вход чило и выдает количество цифр в числе.

456 -> 3
78 -> 2
89126 -> 5
*/

System.Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Quantity(int number)
{
    int count = 0;
    while( number > 0)
    {
        count++;
        number = number / 10;
    }
    return count;
}
System.Console.WriteLine(Quantity(userNumber));