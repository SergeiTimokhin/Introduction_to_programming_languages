// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Число A: ");
int A = Convert.ToInt32(Console.ReadLine());
if (A % 2 == 0)
    Console.Write(A + "->да");
else Console.Write(A + "->нет");
