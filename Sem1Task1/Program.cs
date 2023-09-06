// Задача №1
// Напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(num1 == Math.Pow(num2, 2) ? "Да" : "Нет");
// Тернарная операция - <условие> ? <вариант1> : <вариант2>
//
// Является аналогом:
if (num1 == Math.Pow(num2, 2))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

