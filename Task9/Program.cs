// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


//Вариант 1:
// int number = new Random().Next(10, 100);//10, 99 +1
// Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit == secondDigit) Console.WriteLine("Цифры равны");
// else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} => {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {number} => {secondDigit}");



//Вариант 2:
// int number = new Random().Next(10, 100);//10, 99 +1

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// string result = firstDigit == secondDigit ? "Цифры равны"
// : firstDigit > secondDigit ? firstDigit.ToString() : secondDigit.ToString();
// Console.WriteLine($"Наибольшая цифра числа {number} => {result}");



// Вариант 3:
int number = new Random().Next(10, 100);//10, 99 +1

int firstDigit = number / 10;
int secondDigit = number % 10;

int MaxDigit(int num)
{
int firstDigit = num / 10;
int secondDigit = num % 10;
if (firstDigit == secondDigit) return 0;
return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int result = MaxDigit(number);
string res = result == 0 ? "Цифры равны" : result.ToString();
Console.WriteLine($"Наибольшая цифра числа {number} => {res}");
