/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8, 9  ->  нет */

int firstNumber = ReadInt("Введите первое число: ");
int secondNumber = ReadInt("Введите второе число: ");
int sqr1 = firstNumber*firstNumber;
int sqr2 = secondNumber*secondNumber;

if (secondNumber==sqr1 || firstNumber==sqr2)
{
    if (firstNumber > secondNumber)
    {
        Console.WriteLine($"Число {firstNumber} является квадратом числа {secondNumber}");
    }
    else
    {
        Console.WriteLine($"Число {secondNumber} является квадратом числа {firstNumber}");
    }
}

else
{
    Console.WriteLine("Числа не являются квадратом");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}