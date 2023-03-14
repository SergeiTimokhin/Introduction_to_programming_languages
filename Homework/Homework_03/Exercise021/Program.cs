/* Напишите метод(-ы), который принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве. */

double GetXYZ(string number)
{
    Console.Write(number);
    return Convert.ToDouble(Console.ReadLine());
}
double GetDist(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double Dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return Math.Round(Dist, 1);
}
double x1 = GetXYZ("Введите значение x1: ");
double y1 = GetXYZ("Введите значение y1: ");
double z1 = GetXYZ("Введите значение z1: ");
double x2 = GetXYZ("Введите значение x2: ");
double y2 = GetXYZ("Введите значение y2: ");
double z2 = GetXYZ("Введите значение z2: ");

double Coords = GetDist(x1, y1, z1, x2, y2, z2);

Console.Write("Расстояние между точками: " + Coords);
