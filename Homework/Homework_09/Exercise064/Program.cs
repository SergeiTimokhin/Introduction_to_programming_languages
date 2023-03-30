/*  Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetValue(string value)
{
    Console.Write(value);
    return Convert.ToInt32(Console.ReadLine());
}


string GetResult(int N, int end)
{
    if (N > end) return $"{N}, " + GetResult(N - 1, end);
    else return $"{end}.";
}


int N = GetValue("Введите положительное значение N: ");
int E = GetValue("Введите конечное значение: ");

Console.WriteLine(GetResult(N, E));



