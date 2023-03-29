/* Рукурсии.Собрать строку с числами от a до b */

/* string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}
 */
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return $"{b}. ";
}

/* Console.WriteLine(NumbersFor(1, 10)); */
int t = 1;
int m = 10;
Console.WriteLine(NumbersRec(t, m));
