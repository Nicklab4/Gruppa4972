// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

int numA = int.Parse(System.Console.ReadLine() ?? "0");
int numB = int.Parse(System.Console.ReadLine() ?? "0");

bool test1 = (numA == numB*numB);
bool test2 = (numB == numA*numA);

if (test1)
{
    System.Console.WriteLine(   "Первое число квадрат второго");    
}

if (test2)
{
    System.Console.WriteLine("Второе число - квадрат второго");
}

if (!(test1||test2))
{
    System.Console.WriteLine("Числа - не квадраты друг друга");
}