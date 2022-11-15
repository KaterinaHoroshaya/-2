/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

int check1 = 7;
int check2 = 23;

int result1 = number%check1;
int result2 = number%check2;


if (result1==0 && result2==0)
{
    Console.Write($"{number} кратно обоим числам");
}

else 
{
    Console.WriteLine($"{number} не кратно 7 и 23");
}