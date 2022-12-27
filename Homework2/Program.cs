// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
//Факториал Сложение вместо умножения ///  меньшее число  остановит
// M = 1; N = 15 -> 120 
// M = 4; N = 8. -> 30

int SumNumbers(int M, int N)
{// Условия остановки рекурсии: 
    if (M == 0) return (N * (N + 1)) / 2;  // использую формулу нахождения суммы чисел (N(N+1))/2, где N - наибольшее число ряда.          
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;
// Условия продолжения рекурсии:    
    else if (M < N) return N + SumNumbers(M, N - 1); // Если M < N  
    else return N + SumNumbers(M, N + 1);            // Если M > N
}

Console.Clear();
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {SumNumbers(M, N)}");
Console.WriteLine();
