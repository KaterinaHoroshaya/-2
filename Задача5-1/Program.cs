int firstNumber = ReadInt("Введите первое число: ");
int secondNumber = ReadInt("Введите первое число: ");

if(firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
