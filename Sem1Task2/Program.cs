// Задача 2
// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
//
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

////////////////////////////////
// Вариант решения 1
////////////////////////////////

System.Console.WriteLine("Введите число a");
int numA = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите число b");
int numB = int.Parse(System.Console.ReadLine());

int max = numA;

if (numA < numB)
{
    max = numB;
}

System.Console.WriteLine("a = " + numA + "; b = " + numB + " -> max = " + max);

////////////////////////////////
// Вариант решения 2
////////////////////////////////

System.Console.WriteLine("Введите число a");
int numA2 = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите число b");
int numB2 = int.Parse(System.Console.ReadLine());

if (numA2 < numB2)
    System.Console.WriteLine("a = " + numA2 + "; b = " + numB2 + " -> max = " + numB2);
else
    System.Console.WriteLine("a = " + numA2 + "; b = " + numB2 + " -> max = " + numA2);

////////////////////////////////
// Вариант решения 3
////////////////////////////////

System.Console.WriteLine("Введите число a");
int numA3 = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите число b");
int numB3 = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("a = " + numA3 + "; b = " + numB3 + " -> max = " + (numA3 > numB3 ? numA3 : numB3));