int GetNumber(string num)
{
    Console.Write(num);
    return Convert.ToInt32(Console.ReadLine());
}
bool GetNo(int num)
{
    if (-100 < num && num < 100)
    {

        Console.Write("В заданном числе отсутствует третья цифра");
        return false;
    }
    return true;
}

int GetResult(int num)
{
    while ((-999 > num) || (num > 999))
    {
        num = num / 10;
    }
    num = num % 10;
    if (num < 0)
    {
        num = num * -1;
    }
    return num;
}
int A = GetNumber("Введите число: ");
if (GetNo(A))
{
    Console.WriteLine(GetResult(A));
}
