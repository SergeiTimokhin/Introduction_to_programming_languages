int GetNumber(string num)
{
    Console.Write(num);
    return Convert.ToInt32(Console.ReadLine());
}
bool GetNo(int num)
{
    if (1 <= num && num <= 7)
    {
        return true;
    }
    else
    {
        Console.Write("Это не день недели");
        return false;

    }

}
bool GetResult(int num)
{
    if (num > 5)
    {
        return true;
    }
    return false;
}

int A = GetNumber("Введите число: ");
if (GetNo(A))
{
    if (GetResult(A))
    {
        Console.Write("Это выходной день");
    }
    else
    {
        Console.Write("Это будний день");
    }
}

