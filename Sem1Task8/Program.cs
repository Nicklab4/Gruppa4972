// Задача 8:
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
//
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

////////////////////////////////
// Вариант решения 1
////////////////////////////////

System.Console.WriteLine("Введите целое число");
int num = int.Parse(System.Console.ReadLine() ?? "0");

System.Console.Write(num + " -> ");

for (int i = 2; i <= num; i += 2)
{
    System.Console.Write(i);
    if (i == num | i == (num - 1))
        break;

    System.Console.Write(", ");
}