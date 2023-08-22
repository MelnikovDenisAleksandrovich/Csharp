/*
20. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
*/
System.Console.WriteLine("Введите координаты первой точки");
int userx1 = Convert.ToInt32(Console.ReadLine());
int usery1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты второй точки");
int userx2 = Convert.ToInt32(Console.ReadLine());
int usery2 = Convert.ToInt32(Console.ReadLine());
double S = 0;
S = Math.Sqrt(Math.Pow(userx2 - userx1, 2) + Math.Pow(usery2 - usery1, 2));
Console.Write("Расстояние между двумя точками:" + Math.Round(S, 2));