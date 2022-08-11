// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите чилсо: ");
int number = int.Parse(Console.ReadLine());

string num = Convert.ToString(Math.Abs(number));

if (num.Length > 2)
{
    Console.Write($"Третья цифра числа {number}: {num[2]}");
}
else
{
    Console.Write($"В числе {number} третьей цифры нет");
}