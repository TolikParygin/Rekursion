// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void EnterNumber(int n)
{
    if (n == 0) return;
    System.Console.Write(n + " ");
    EnterNumber(n - 1);
}

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
EnterNumber(number);