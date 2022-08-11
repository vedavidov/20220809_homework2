// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное чилсо: ");
int number = int.Parse(Console.ReadLine());

int AbsNumber = Math.Abs(number);

int a = number % 100;
int b = a / 10;

if ((AbsNumber < 100) || (AbsNumber > 1000))
{
    Console.Write($"Число {number} не является трёхзначным");
}

else
{
    Console.Write($"Вторая цифра числа {AbsNumber}: {b}");
}