/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

y = k1 * x + b1 
y = k2 * x + b2
K1*x+b1=k2*x+b2
x=(b2-b1)/(k1-k2)
y=k1*(b2-b1)/(k1-k2)+b1
*/


/* int GetNumber(string Value)
{
    Console.Write(Value);
    return Convert.ToInt32(Console.ReadLine());
} */

int GetNumber(string Value)
{
    Console.Write(Value);
    return Convert.ToInt32(Console.ReadLine());
}

double GetCoordinateX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    if (k1 == k2) Console.WriteLine("Прямые не пересекаются");
    else Console.WriteLine($"Координата X = {Math.Round(x, 1)};");
    return Math.Round(x, 1);
}

double GetCoordinateY(double b1, double k1, double b2, double k2)
{
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    if (k1 == k2) Console.Write("");
    else Console.Write($"Координата Y = {Math.Round(y, 1)};");
    return Math.Round(y, 1);
}

double b1 = GetNumber("Введите коэффициент b1: ");
double k1 = GetNumber("Введите коэффициент k1: ");
double b2 = GetNumber("Введите коэффициент b2: ");
double k2 = GetNumber("Введите коэффициент k2: ");
Console.WriteLine("*****************************");
Console.WriteLine("Точка пересечения прямых:");
double X = GetCoordinateX(b1, k1, b2, k2);
double Y = GetCoordinateY(b1, k1, b2, k2);