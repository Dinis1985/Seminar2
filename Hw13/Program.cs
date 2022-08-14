// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Решить без использования строк.
// Пример:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number;

if (number <= 100) Console.WriteLine($"Третья цифра числа {number} -> отсутствует ");
else if (number >= 1000) Console.WriteLine($"Третья цифра числа {result / 10 % 10}");
else if (number >= 10000) Console.WriteLine($"Третья цифра числа {(result / 100) % 10}");
else if (number >= 100000) Console.WriteLine($"Третья цифра числа {(result / 1000) % 10}");
else if (number >= 1000000) Console.WriteLine($"Третья цифра числа {result / 10000 % 10}");
else if (number >= 10000000) Console.WriteLine($"Третья цифра числа {result / 100000 % 10}");
else if (number >= 100000000) Console.WriteLine($"Третья цифра числа {result / 1000000 % 10}");
else if (number >= 1000000000) Console.WriteLine($"Третья цифра числа {result / 10000000 % 10}");
else Console.WriteLine($"Третья цифра числа {result % 10}");
// {
//     int result = number;
//     for (; number >= 1000; number /= 10) Console.WriteLine($"Третья цифра числа {result % 10}");
// } 


// if (result < 0) Console.WriteLine($"Третья цифра числа {number} -> {result * -1}");
// // else 
// Console.WriteLine($"Третья цифра числа {number} -> {result} ");



// if (N < 100) cout << "нету";
// else
// {
//     for (; N >= 1000; N /= 10)
//         ;
//     ccut << N % 10;
// }





// if (number < 100)
// {
//     Console.WriteLine("Третья цифра числа {number} - отсутствует");
// }
// else if (result < 0) 
// {
//     Console.WriteLine($"Третья цифра числа {number} -> {result * -1}");
// }
// else if (result >= 1000) 
// {
//     Console.WriteLine($"Третья цифра числа {number} -> {result % 100}");
// }
// else
// {
//     Console.WriteLine($"Третья цифра числа {number} -> {result}");
// }




