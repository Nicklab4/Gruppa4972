// Задача 6:
// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
//
// 4 -> да
// -3 -> нет
// 7 -> нет

////////////////////////////////
// Вариант решения 1
////////////////////////////////

System.Console.WriteLine("Введите целое число");
int num = int.Parse(System.Console.ReadLine() ?? "0");

if (num % 2 == 0)
    System.Console.WriteLine(num + " -> Да");
else
    System.Console.WriteLine(num + " -> Нет");

////////////////////////////////
// Вариант решения 2
////////////////////////////////

System.Console.WriteLine("Введите целое число");
int num2 = int.Parse(System.Console.ReadLine() ?? "0");

System.Console.WriteLine(num2 + " -> " + (num2 % 2 == 0 ? "Да" : "Нет"));