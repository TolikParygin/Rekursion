// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int EnterNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Sum(int n, int m)
{
    if (n == m)
    {
        return n;
    }
    else
    {
        return n + Sum(n + 1, m);
    }
}

int firstNumber = EnterNumber("Enter first number: ");
int secondNumber = EnterNumber("Enter second number: ");
Console.WriteLine(Sum(firstNumber, secondNumber));