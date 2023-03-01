// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= N)
{
    if (index % 2 == 0)
        if (index > N - 1)
            //if (index == N || index == N - 1)
            Console.Write(index);
        else
            Console.Write(index + ", ");
    index++;
}
