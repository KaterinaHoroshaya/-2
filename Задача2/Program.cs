/* Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98 */

int randomNumber = new Random().Next(100,1000);
int lastDigit = randomNumber % 10;
int firstDigit = randomNumber / 100;

Console.WriteLine(randomNumber);

Console.WriteLine($"{firstDigit} и {lastDigit}");

