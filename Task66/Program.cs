// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSum (int m, int n)
{
    if (n == m)
        return m;
    return GetSum(m, n-1) + n;
}

Console.Clear();
Console.Write("Введите 2 числа: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine(GetSum(numbers[0], numbers[1]));