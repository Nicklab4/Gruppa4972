// Задача №11
// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.

int num = new Random().Next(100, 1000);
System.Console.WriteLine(   num);

int firstDigit = num / 100;
int secondDigit = num % 10;

num = firstDigit*10 + secondDigit;

System.Console.WriteLine(num);

