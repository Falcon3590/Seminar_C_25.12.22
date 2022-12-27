// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// Факториал
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void DescendingNum(int N)
{
    if(N >= 3)
    {
        Console.Write($"{N - 1} ");
        DescendingNum(N - 1);
    }

}

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Все натуральные числа в промежутке от {N} до 1: ");
DescendingNum(N);

