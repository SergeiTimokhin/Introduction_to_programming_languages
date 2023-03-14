// FOR. Цикл в цикле 
// Заменить пробелы на |, маленькие "к" на большие "К", а большие "З" на маленькие "з" 

//string s = "qwerty"
//s[3] это r
// Тип CHAR хранит 1 символ. Задаётся одинарными кавычками ' '

string text = "1.1.Заказчик поручает, а Исполнитель по поручению Заказчика предоставляет"
                + "услуги по проведению строительно-технической обследования (далее «Работа»)"
                + "установленных оконных блоков (далее «Объект») на фасадах здания,"
                + "расположенного по адресу: Калининградская обл., г.Зеленоградск, ул.Гагарина, 12б";


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string NewText = Replace(text, ' ', '|');
NewText = Replace(NewText, 'к', 'К');
NewText = Replace(NewText, 'З', 'з');
Console.Write(NewText);