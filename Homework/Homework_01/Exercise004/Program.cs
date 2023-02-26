// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Число C: ");
int C = Convert.ToInt32(Console.ReadLine());
int max;
max = (int)(A);
if (B > max) max = B;
if (C > max) max = C;
Console.Write("max= ");
Console.Write(max);