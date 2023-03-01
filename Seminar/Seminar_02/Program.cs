// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

void Square(int A, int B)
{
    if (A == B * B)
    {
        Console.Write("А является квадратом B");
    }
    else Console.Write("А не является квадратом B");
}
Console.Write("Число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Число B: ");
int B = Convert.ToInt32(Console.ReadLine());

Square(A, B);