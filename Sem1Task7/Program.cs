// Задача №7
// Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает последнюю цифру этого числа.

////////////////////////////////
// Вариант решения 1
////////////////////////////////

System.Console.WriteLine("ВВедите число");
int num = int.Parse(System.Console.ReadLine() ?? "0");

System.Console.WriteLine(num < 1000 && num > 99 ? num % 10 : "Число не трёхзначное");

////////////////////////////////
// Вариант решения 2
////////////////////////////////

System.Console.WriteLine("Введите число");
int num1 = int.Parse(System.Console.ReadLine() ?? "0");

if (num1 < 1000 && num1 > 99)
{
    int lastNum = num1 % 10;
    System.Console.WriteLine("Последнее чиcло " + num1 + " это " + lastNum);
}