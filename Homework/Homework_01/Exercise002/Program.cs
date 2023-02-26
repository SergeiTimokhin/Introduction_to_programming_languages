// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Число B: ");
int B = Convert.ToInt32(Console.ReadLine());
if (A > B)
    Console.Write("max=" + A);
else Console.Write("max=" + B);