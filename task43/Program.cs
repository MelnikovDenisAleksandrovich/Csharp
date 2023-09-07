/*
Напишите программу, которая найдет точку пересечение двух прямых 
заданных уровнениями y = k1 * x + b2 = 2 значения b1, k1, b2 и k2 задаются пользователем .
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (- 05; - 05)
 */

Console.Clear();

/*Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

/*
Упростим (решим) уравнение, для получение кординат:
y =k1 * x +b1, y =k2 *x +b2
k1 * x +b1 = k2 * x + b2 (переносим влево значение с Х и выносим Х за скобки)
(k1 - k2) * x = b1 - b2 ( делим обе части на (k1 - k2))
x = (b2 - b1) / (k1 - k2)
y = k1 * x + b1
*/

/*
double  x = (b2 - b1) / (k1 - k2);
double  y = k1 * x + b1;

Console.Write($"Точка пересечение находится в кординатах: x = {x}; y = {y}]");

*/

Console.Write("Введите значение точки b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение точки b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение точки k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение точки k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

float x = CalculationX(b1, b2, k1, k2);
float y = CalculationY(x, b1, k1);

if (CheckCoords(b1, b2, k1, k2))
{
    Console.WriteLine($"({x}; {y})");
}

float CalculationX(int b1, int b2, int k1, int k2)
{
    float x = (float)(b2 - b1) / (k1 - k2);

    return x;
}

float CalculationY( float x, int b1, int k1 )
{
    float y = (float)(k1 * x + b1);

    return y;
}

bool CheckCoords(int b1, int b2, int k1, int k2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые паралейны");
            return false;
        }
    }
    return true;
}