/* Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе*/

/* 
НЕ СМОГ ДОРАБОТАТЬ РЕШЕНИЕ ЧЕРЕЗ МАССИВ. НЕ СРАБАТЫВАЕТ РАССЧЁТ.
ПРОШУ ПРИ ПРОВЕРКЕ УКАЗАТЬ НА НЕДОЧЁТЫ.

    string GetNum(string number)
{
    Console.Write(number);
    return Console.ReadLine();
}

int GetSum(string A)
{
    char[] chars = A.ToCharArray();
    int sum = 0;
    for (int i = 0; i < chars.Length; i++)
    {
        sum = sum + chars[i];
    }
    return sum;
}

string A = GetNum("Введите число: ");
GetSum(A);
Console.Write(A); */

int GetNumber(string A)
{
    Console.Write(A);
    return Convert.ToInt32(Console.ReadLine());
}
int GetRes(int A)
{
    int sum = 0;
    while (A > 0)
    {
        sum = sum + A % 10;
        A = A / 10;
    }
    return sum;
}
int A = GetNumber("Введите число: ");
int result = GetRes(A);
Console.WriteLine(result);