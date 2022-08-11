// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное чилсо: ");
int number = int.Parse(Console.ReadLine());

int num1 = number % 100;
int num2 = num1 / 10;

if ((number < 100) || (number > 1000))
{
    Console.Write($"Число {number} не является трёхзначным");
}

else
{
    Console.Write($"Вторая цифра числа {number}: {num2}");
}