// Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число некратно первому,
// то программа выводит остаток от деления.

////////////////////////////////
// Вариант решения 1
////////////////////////////////

int numA = int.Parse(System.Console.ReadLine() ?? "0");
int numB = int.Parse(System.Console.ReadLine() ?? "0");

if (numB % numA == 0)
    System.Console.WriteLine("Второе число кратно первому");
else
{
    System.Console.WriteLine("Второе число не кратно первому");
    System.Console.WriteLine("Остаток от деления: " + numB % numA);
}

////////////////////////////////
// Вариант решения 2
////////////////////////////////

int f = int.Parse(System.Console.ReadLine() ?? "0");
int s = int.Parse(System.Console.ReadLine() ?? "0");

System.Console.WriteLine((s % f == 0) ? "Второе число кратно первому" : ("Остаток от деления: " + s % f));

////////////////////////////////
// Вариант решения 3
////////////////////////////////

System.Console.WriteLine("Введите первое число");
int num31 = int.Parse(Console.ReadLine() ?? "0");

System.Console.WriteLine("Введите второе число");
int num32 = int.Parse(Console.ReadLine() ?? "0");

System.Console.WriteLine(num32 % num31 == 0 ? "Второе чило кратно первому" : "Остаток от деления: " + (num32 % num31));