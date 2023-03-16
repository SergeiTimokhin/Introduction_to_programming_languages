/*  
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве  
[345, 897, 568, 234] -> 2
*/
int GetLength(string Value)
{
    Console.Write(Value);
    return Convert.ToInt32(Console.ReadLine());
}

int GetMinMax(string Value)
{
    Console.Write(Value);
    return Convert.ToInt32(Console.ReadLine());

}
/* while (true)
{
    var input = Console.ReadLine();
    if (int.TryParse(input, out result) && (result >= 99 && result <= 1000))
        break;
    else
    {
        Console.Wr
    }
} */


/* int GetMinMax(string Value)
{
    Console.Write(Value);
    return Convert.ToInt32(Console.ReadLine());
} */


int[] GetArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}
void Print(int[] array)
{
    Console.WriteLine("Массив:");
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

int GetSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}


int length = GetLength("Введите длину массива: ");
int min = GetMinMax("Введите наименьший трёхзначный элемент массива: ");
int max = GetMinMax("Введите наибольший трёхзначный элемент массива: ");
int[] array = GetArray(length, min, max);
Console.WriteLine();
Print(array);
int sum = GetSum(array);
Console.WriteLine();
Console.WriteLine("Сумма чётных значений: " + GetSum(array));

