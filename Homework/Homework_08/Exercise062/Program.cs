/*  
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int GetSize(string value)
{
    Console.Write(value);
    return Convert.ToInt32(Console.ReadLine());
}

void GetArray(int[,] array, int A)
{
    int i = 0;
    int j = 0;
    int x = 1;
    while (A != 0)
    {
        int k = 0;
        do { array[i, j++] = x++; }
        while (A - 1 > ++k);
        for (k = 0; k < A - 1; k++)
        {
            array[i++, j] = x++;
        }
        for (k = 0; k < A - 1; k++)
        {
            array[i, j--] = x++;
        }
        for (k = 0; k < A - 1; k++)
        {
            array[i--, j] = x++;
        }
        ++i;
        ++j;
        A = A < 2 ? 0 : A - 2;
    }
}
void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0,3}", a[i, j]);
        }
        Console.WriteLine();
    }
}

int A = GetSize("Введите размер массива: ");
int[,] array = new int[A, A];
GetArray(array, A);
PrintArray(array);
Console.WriteLine();