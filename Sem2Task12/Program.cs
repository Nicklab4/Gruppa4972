// Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число некратно первому,
// то программа выводит остаток от деления.

int numA = int.Parse(System.Console.ReadLine() ?? "0");
int numB = int.Parse(System.Console.ReadLine() ?? "0");

if (numB % numA == 0)
    System.Console.WriteLine("Второе число кратно первому");
else
{
    System.Console.WriteLine("Второе число не кратно первому");
    System.Console.WriteLine("Остаток от деления: " + numB % numA);
}