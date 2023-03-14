/* Напишите метод(-ы), который принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. */

int GetNumber(string num)
{
    Console.Write(num);
    return Convert.ToInt32(Console.ReadLine());
}
bool GetNo(int num)
{
    if (num / 100000 > 0)
    {
        Console.Write("Это не пятизначное число");
        return false;

    }
    return true;
}

bool IsPalindrome(int num)
{
    if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10)
    {
        return true;
    }
    else
    {
        return false;
    }
}
int A = GetNumber("Введите пятизначное число: ");
if (GetNo(A))
{
    if (IsPalindrome(A))
    {
        Console.WriteLine("Это число - палиндром");
    }
    else
    {
        Console.WriteLine("Это число - не палиндром");
    }
}

