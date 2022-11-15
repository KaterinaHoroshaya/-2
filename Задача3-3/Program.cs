int firstNumber = ReadInt("Введите первое число: ");
int secondNumber = ReadInt("Введите второе число: ");

int remainder = firstNumber % secondNumber;

if(remainder == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"{firstNumber} Не кратно {secondNumber}, {remainder}");
    Console.WriteLine("Не кратно, " + remainder);
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

