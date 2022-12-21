// сумма цифр от N до M

void Sum(int n, int m)
{
    if (n > m)
        return;
    System.Console.Write(n + " ");
    Sum(n + 1, m);
}

Console.Write("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine());
Sum(firstNumber, secondNumber);