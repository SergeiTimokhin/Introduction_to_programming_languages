/*  Задайте прямоугольный (ПО ПРИМЕРУ - КВАДРАТНЫЙ) двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int GetValue(string value)
{
    Console.Write(value);
    return Convert.ToInt32(Console.ReadLine());
}

void GetArray(double[,] array)
{
    Random temp = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double SumLineElements(double[,] array, int i)
{
    double sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}
double GetResult(double[,] array, double sumLine)
{
    double minSumLine = 0;
    sumLine = SumLineElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        double tempSumLine = SumLineElements(array, i);

        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }
    return minSumLine;

}

int m = GetValue("Введите размер массива : ");
double[,] A = new double[m, m];

GetArray(A);
Console.WriteLine("Исходный массив:");
PrintArray(A);
double sumLine = SumLineElements(A, 0);
double result = GetResult(A, sumLine);

Console.WriteLine($"\n{result + 1} - строка с наименьшей суммой элементов");