// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// Пример:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7: ");
int a = Convert.ToInt32(System.Console.ReadLine());

if (a < 1 || a > 7)
{
    Console.WriteLine("!!!Вы ввели не корректное значение!!!");
}
else if (a == 6 || a == 7)
{
    Console.WriteLine($"{a} -> выходной ");
}
else
{
    Console.WriteLine($"{a} -> не выходной ");
}


