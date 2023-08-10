/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.Write("Понедельник-Идти на работу");
}
else if (number == 2)
{
    Console.Write("Вторник-Идти на работу");
}
else if (number == 3)
{
    Console.Write("Среда-Идти на работу");
}
else if (number == 4)
{
    Console.Write("Четверг-Идти на работу");
}
else if (number == 5)
{
    Console.Write("Пятница-Идти на работу");
}
else if (number == 6)
{
    Console.Write("Суббота-Выходной");
}
else if (number == 7)
{
    Console.Write("Воскресенье-Выходной");
}
else
{
    Console.Write("Такого дня нет");
}