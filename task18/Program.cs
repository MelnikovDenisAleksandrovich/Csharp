/* Напишите программу, которая по заданному номеру четверти, показывает 
диапазон возможных координат точек в этой четверти (x и y).
*/
Console.WriteLine("Введите № четверти: ");
int numberCh = Convert.ToInt32(Console.ReadLine());
if (numberCh == 1)
{
    Console.WriteLine("Все X > 0, все Y > 0 ");
}
else if (numberCh == 2)
{
    Console.WriteLine("Все X < 0, все Y > 0 ");
}
else if (numberCh == 3)
{
    Console.WriteLine("Все X < 0, все Y < 0 ");
}
else if (numberCh == 4)
{
    Console.WriteLine("Все X > 0, все Y < 0 ");
}
else Console.WriteLine("Нет такой четверти  ");
