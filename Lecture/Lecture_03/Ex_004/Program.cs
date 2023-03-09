//Метод №4 Принимает, возвращает

string Method_4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method_4(10, "текст");
Console.WriteLine(res);
