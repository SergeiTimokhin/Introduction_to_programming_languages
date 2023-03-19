/*  
Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int GetLength(string Value)
{
    Console.Write(Value);
    return Convert.ToInt32(Console.ReadLine());
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetLength($"{i + 1}-й элемент: ");
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Массив элементов: [");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}
int GetPisitiveNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}

int length = GetLength("Введите колличество элементов:  ");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine();
Console.Write($"Введённых чисел больше нуля: {GetPisitiveNumber(array)}");


