/* Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе*/


/* РЕШЕНИЕ ЧЕРЕЗ МАССИВ*/

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
        sum += Convert.ToInt32(chars[i].ToString());
    }
    return sum;
}

string A = GetNum("Введите число: ");
int res = GetSum(A);
Console.WriteLine($"Сумма цифр равна: {res}");

/* РЕШЕНИЕ ЧЕРЕЗ АРИФМЕТИЧЕСКИЕ ДЕЙСТВИЯ*/

/* int GetNumber(string A)
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
Console.WriteLine($"Сумма цифр равна: {result}"); */