int GetNumber(string s)
{
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}

int GetResult(int num)
{
    int x = num / 10;
    int y = num % 10;
    num = x + y;
    return num;
}

int N = GetNumber("Введите трёхзначное число: ");
int result = GetResult(N);
Console.WriteLine(result);