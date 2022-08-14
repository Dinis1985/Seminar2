// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Решить без использования строк.
// Пример:
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num1 = number / 10;
int result = num1 % 10;

if (result < 0)
{
    Console.WriteLine($"Вторая цифра числа {number} -> {result * -1}");
}
else
{
    Console.WriteLine($"Вторая цифра числа {number} ->  {result}");
}
