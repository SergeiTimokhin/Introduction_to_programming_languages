// Цикл FOR

string Method_4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method_4(10, "текст");
Console.WriteLine(res);
