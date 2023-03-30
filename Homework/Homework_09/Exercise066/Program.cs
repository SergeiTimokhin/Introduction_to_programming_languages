/* Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetValue(string value)
{
    Console.Write(value);
    return Convert.ToInt32(Console.ReadLine());
}

string GetList(int m, int n)
{

    if (m < n)
    {
        if (m < n) return $"{m}, " + GetList(m + 1, n);
        else return $"{n}.";
    }
    else
    {
        if (m > n) return $"{n}, " + GetList(m, n + 1);
        else return $"{m}.";
    }
}
int GetSum(int k, int s)
{

    if (k > s) return 0;
    else return k + GetSum(k + 1, s);
}


/* int GetSum(int m, int n)
{
    int sum = 0;
    if (m < n)
    {
        while (m <= n)
        {
            sum = sum + m;
            m++;
        }
        return sum;
    }
    else
    {
        while (m >= n)
        {
            sum = sum + n;
            n++;
        }
        return sum;
    }
} */


int M = GetValue("Введите меньшее из чисел(M): ");
int N = GetValue("Введите большее из чисел (N): ");
Console.Write("Список натуральных элементов: ");
Console.WriteLine(GetList(M, N));
Console.Write("Сумма натуральных элементов: ");
Console.WriteLine(GetSum(M, N));