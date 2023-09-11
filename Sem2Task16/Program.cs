// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

int numA = int.Parse(System.Console.ReadLine() ?? "0");
int numB = int.Parse(System.Console.ReadLine() ?? "0");

bool test1 = (numA == numB * numB);
bool test2 = (numB == numA * numA);

if (test1)
{
    System.Console.WriteLine("Первое число - квадрат второго");
}

if (test2)
{
    System.Console.WriteLine("Второе число - квадрат второго");
}

if (!(test1 || test2))
{
    System.Console.WriteLine("Числа - не квадраты друг друга");
}

////////////////////////////////
// Вариант решения 2
////////////////////////////////

int GetNum()
{
    System.Console.WriteLine("Введите число: ");
    return Convert.ToInt32(System.Console.ReadLine());
}

int firstNum = GetNum();
int secondNum = GetNum();

bool firstPow = firstNum == Math.Pow(secondNum, 2);
bool secondPow = secondNum == Math.Pow(firstNum, 2);

System.Console.WriteLine(firstPow || secondPow ? "Одно из чисел является квадратом второго" : "Ни одно из чисел не является квадратом другого");

////////////////////////////////
// Вариант решения 3
////////////////////////////////

int a = int.Parse(System.Console.ReadLine());
int b = int.Parse(System.Console.ReadLine());

bool test31 = (a == b * b);
bool test32 = (b == a * a);

if (test1)
    System.Console.WriteLine("Первое число - квадрат второго");
else if (test2)
    System.Console.WriteLine("Второе число - квадрат первого");
else
    System.Console.WriteLine("Ни одно число не является квадратом другого");