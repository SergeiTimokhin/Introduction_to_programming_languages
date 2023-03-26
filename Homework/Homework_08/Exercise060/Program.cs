/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/* int GetValue(string value)
{
    Console.Write(value);
    return Convert.ToInt32(Console.ReadLine());
}

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100);
        }
    }
}
void PrintArray(int[,] array)
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

int[,] GetResult(int[,] a, int[,] b, int m)
{
    int[,] c = new int[m, m];

    int temp = 0;

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(1); k++)
            {
                temp = temp + a[i, k] * b[j, k];
            }
            c[i, j] = temp;
            temp = 0;
        }
    }
    return c;
}

int m = GetValue("Введите размер матриц: ");

int[,] arrayA = new int[m, m];
int[,] arrayB = new int[m, m];
GetArray(arrayA);
GetArray(arrayB);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
int[,] multiArray = GetResult(arrayA, arrayB, m);
PrintArray(multiArray);
 */

void GetArray(int[] array)
{
    array[0] = 10;
    int step = 1;
    for (int i = 1; i < array.Length; i++)
    {
        array[i] = array[i - 1] + step;
    }
}

void mixArray(int[] array)
{
    Random random = new Random();
    for (int i = array.Length - 1; i >= 1; i--)
    {
        int j = random.Next(i + 1);
        var temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine("Массив данных из двузначных чисел: ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}.");
}

int[,,] GetResult(int[] array, int x, int y, int z)
{
    int[,,] array3D = new int[x, y, z];
    int m = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = array[m];
                m++;
            }
        }
    }
    return array3D;
}
void PrintArray3D(int[,,] array3D)
{

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ({i},{j},{k}) ");
            }
        }
    }
}

int[] array = new int[90];
GetArray(array);
mixArray(array);
PrintArray(array);
int x = 2;
int y = 2;
int z = 2;
GetResult(array, x, y, z);
int[,,] array3D = GetResult(array, x, y, z);
Console.WriteLine("=====================");
Console.Write("Трёхмерный массив: ");
PrintArray3D(array3D);

