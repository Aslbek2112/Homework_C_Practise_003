/*    Задача 19.
 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. */
Console.Clear();
Console.Write("Введите пятизначное число: ");
string input = Console.ReadLine()?? "";

if (input.Length != 5 || !int.TryParse(input, out int number))
{
    Console.WriteLine("Некорректный ввод! Введите пятизначное число.");
}

number = int.Parse(input);
int digit1 = number/10000;
int digit2 = (number/1000) % 10;
int digit4 = (number/10) % 10;
int digit5 = number % 10;

if (digit1 == digit5 && digit2 == digit4)
{
    Console.Write($"Число {number} является палиндромом");
}
else
{
    Console.Write($"Число {number} не является палиндромом");
}

