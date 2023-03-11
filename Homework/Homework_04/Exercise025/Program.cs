/*  Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B */

int GetNumberA(string num_A)
{
    Console.Write(num_A);
    return Convert.ToInt32(Console.ReadLine());
}
int GetNumberB(string num_B)
{
    Console.Write(num_B);
    return Convert.ToInt32(Console.ReadLine());
}
int GetResult(int num_A, int num_B)
{
    int i = 1;
    int result = num_A;
    while (i < num_B)
    {
        result = result * num_A;
        i++;
    }
    return result;
}

int A = GetNumberA("Введите число A: ");
int B = GetNumberB("Введите число B: ");
int res = GetResult(A, B);
Console.WriteLine("A в степени B = " + res);

