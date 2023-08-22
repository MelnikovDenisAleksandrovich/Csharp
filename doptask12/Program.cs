/*Два автомобиля едут навстречу друг другу с постоянными скоростями V1 и  V2 км/час. Определить, через какое время автомобили встретятся, если расстояние между ними было S км.
*/
Console.WriteLine("Введите скорость 1");
int V1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость 2");
int V2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите растояние");
double S = Convert.ToInt32(Console.ReadLine());
double t = (double)S / (V1 + V2);
Console.WriteLine($"Время встречи через {(int)t} Часов {((t - (int)t) * 60):N0} минут ");
