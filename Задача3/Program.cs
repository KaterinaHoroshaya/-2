﻿/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно */

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int Ostatok = 0;

if (firstNumber == secondNumber * secondNumber)
{
    System.Console.WriteLine($"Число {secondNumber} является кратным числу {firstNumber}");
}

else
{
    Ostatok = firstNumber % secondNumber;
    System.Console.WriteLine($"Число {secondNumber} не является кратным числу {firstNumber}, остаток от деления равен {Ostatok}");
}