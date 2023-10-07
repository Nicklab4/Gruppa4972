// Задача 63

// Задайте занчение N. Напишите программу, которая выведет все натруральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// Метод ввода данных
int ReadData(string msg)
{
    System.Console.WriteLine(msg);
    int num = int.Parse(System.Console.ReadLine() ?? "0");
    return num;
}

void GenLineNum(int num)
{
    System.Console.Write(num + " ");
    if (num > 1)
        GenLineNum(num - 1);
}

int num = ReadData("Введите число");

GenLineNum(num);