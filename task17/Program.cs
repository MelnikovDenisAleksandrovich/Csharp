/*
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

System.Console.WriteLine("Введите X и Y вашей точки: ");
int userX = Convert.ToInt32(Console.ReadLine());
int userY = Convert.ToInt32(Console.ReadLine());

if (userX > 0 && userY > 0)
{
    System.Console.WriteLine($"Точка [{userX} : {userY}] находится в первой четверти ");
}
else if (userX < 0 && userY > 0)
{
    System.Console.WriteLine($"Точка [{userX} : {userY}] находится во второй четверти ");
}
else if (userX < 0 && userY < 0)
{
    System.Console.WriteLine($"Точка [{userX} : {userY}] находится в третьей четверти ");
}
else if (userX > 0 && userY < 0)
{
    System.Console.WriteLine($"Точка [{userX} : {userY}] находится в четвертой четверти ");
}