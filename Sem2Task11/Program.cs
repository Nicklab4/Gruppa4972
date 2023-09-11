// Задача №11
// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.

////////////////////////////////
// Вариант решения 1
////////////////////////////////

int num = new Random().Next(100, 1000);
System.Console.WriteLine(num);

int firstDigit = num / 100;
int secondDigit = num % 10;

num = firstDigit * 10 + secondDigit;

System.Console.WriteLine(num);

////////////////////////////////
// Вариант решения 2
////////////////////////////////

int rnd = new Random().Next(100, 1000);
char[] digitChar = rnd.ToString().ToCharArray();

System.Console.WriteLine(rnd);
System.Console.Write(digitChar[0]);
System.Console.Write(digitChar[2]);
System.Console.WriteLine();

////////////////////////////////
// Вариант решения 3
////////////////////////////////
///

System.Console.WriteLine("Введите число");

string stringNum = System.Console.ReadLine()?? "0";
int num3 = Convert.ToInt32(stringNum);

if (stringNum.Length == 3)
    System.Console.WriteLine((num3 / 100)*10 + (num3 % 10));
else 
    System.Console.WriteLine("Число не трёхзначное");

