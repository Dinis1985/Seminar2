// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);//10, 99 +1
//Cosole.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

//if (firstDigit == secondDigit) Console.WriteLine("Цифры равны");
//else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} => {firstDigit}");
//else Console.WriteLine($"Наибольшая цифра числа {number} => {secondDigit}");

string result = firstDigit == secondDigit ? "Цифры равны"
: firstDigit > secondDigit ? firstDigit.ToString() : secondDigit.ToString();
Console.WriteLine($"Наибольшая цифра числа {number} => {result}");
