// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int num1 = number / 100;
int num3 = number % 10;
int result = num1 * 10 + num3;

Console.WriteLine($"Вывод 3х значного числа: {number}");
Console.WriteLine($"Вывод: {num1}");
Console.WriteLine($"Вывод: {num3}");
Console.WriteLine($": {result}");
