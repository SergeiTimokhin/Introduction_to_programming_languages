int GetNumber(string x)
{
    Console.Write(x);
    return Convert.ToInt32(Console.ReadLine());
}
int GetResult(int y)
{
    int num = 1;
    while (num <= y)
    {
        num = num * num * num;
        if (num == y * y * y)

            Console.Write(num);
        else

            Console.Write(num + ",");


        num = Convert.ToInt32(Math.Pow(num, 1.0 / 3.0));
        num = num + 1;
    }
    return num;

}
int N = GetNumber("Введите число: ");
int result = GetResult(N);
