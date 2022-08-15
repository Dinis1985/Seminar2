// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Решить без использования строк.
// Пример:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number;

if (num1 < 100) Console.WriteLine($"Третья цифра числа {number} -> отсутствует ");
else
{
    while (num1 >= 1000)
    {
        num1 = num1 / 10;
    }
    int res = num1 % 10;
    Console.WriteLine($"Третья цифра числа {number} -> {res}");
}

// if (res < 0)
// {
//     Console.WriteLine($"Третья цифра числа: {res * -1}");
// }
// else 
// {
//     Console.WriteLine($"Третья цифра числа {number} -> {res}");
// }

