﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2, не равное 0: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int res = num1 % num2;
if (res == 0)
{
    Console.WriteLine("Кратно ");
}
else 
{
    Console.WriteLine($"Не кратно, остаток -> {res}");
}


