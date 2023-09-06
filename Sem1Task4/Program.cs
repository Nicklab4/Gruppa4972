// Задача 4:
// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

////////////////////////////////
// Вариант решения 1
////////////////////////////////

System.Console.WriteLine("Введите число a");
int numA = int.Parse(System.Console.ReadLine()??"0");

System.Console.WriteLine("Введите число b");
int numB = int.Parse(System.Console.ReadLine()??"0");

System.Console.WriteLine("Введите число c");
int numC = int.Parse(System.Console.ReadLine()??"0");

int max = numA;

if (max < numB)
    max = numB;
if (max < numC)
    max = numC;

System.Console.WriteLine("a = " + numA + "; b = " + numB + "; c = " + numC + " -> max = " + max);

////////////////////////////////
// Вариант решения 2
////////////////////////////////

System.Console.WriteLine("Введите число a");
int numA2 = int.Parse(System.Console.ReadLine()??"0");

System.Console.WriteLine("Введите число b");
int numB2 = int.Parse(System.Console.ReadLine()??"0");

System.Console.WriteLine("Введите число c");
int numC2 = int.Parse(System.Console.ReadLine()??"0");

if (numA2 > numB2 && numA2 > numC2)
    System.Console.WriteLine("a = " + numA2 + "; b = " + numB2 + "; c = " + numC2 + " -> max = " + numA2);
if (numB2 > numA2 && numB2 > numC2)
    System.Console.WriteLine("a = " + numA2 + "; b = " + numB2 + "; c = " + numC2 + " -> max = " + numB2);
if (numC2 > numA2 && numC2 > numB2)
    System.Console.WriteLine("a = " + numA2 + "; b = " + numB2 + "; c = " + numC2 + " -> max = " + numC2);


