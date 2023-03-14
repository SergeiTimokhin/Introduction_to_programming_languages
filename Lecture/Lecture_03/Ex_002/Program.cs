//Метод №2 Принимает аргумент, ничего не возвращает

/* void Method_2(string msg)
{
    Console.Write(msg);
}
Method_2("Текст сообщения");

или  */

void Method_2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method_2(msg: "Текст сообщения", count: 4);