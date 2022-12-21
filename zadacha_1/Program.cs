// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

System.Console.Write("Веедите число N: ");
int number = int.Parse(Console.ReadLine());

void PrintNumber(int num)
{
    if (num > 1)
    {
        PrintNumber(num - 1);
    }
    Console.Write($"{num} ");
}

PrintNumber(number);

