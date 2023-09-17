// Задача 24
// Напишите программу, которая принимает на вход число А и и выдаёт сумму чисел от 1 до А


//вводим данные
int ReadData(string msg)
{
    System.Console.WriteLine(msg);
    int num = int.Parse(System.Console.ReadLine() ?? "0");
    return num;
}

// Печатаем результат
void PrintRezult(string msg)
{
    System.Console.WriteLine(msg);
}


// 1) Вводим число от пользователя
// 2) вычисляем сумму
// 3)   Выводим результат

int SimpleSum(int num)
{
    int sumOfNumber = 0;

    for (int i = 1; i <= num; i++)
    {
        sumOfNumber += i;
    }

    return sumOfNumber;
}

int GauseSum(int num)
{
    int sumOfNumber = 0;

    sumOfNumber = (num * (num + 1)) / 2;

    return sumOfNumber;
}

int numberA = ReadData("Введите число:");

DateTime d1 = DateTime.Now;
int res1 = SimpleSum(numberA);
System.Console.WriteLine(DateTime.Now - d1);

d1 = DateTime.Now;
int res2 = GauseSum(numberA);
System.Console.WriteLine(DateTime.Now - d1);

PrintRezult("Сумма чисел от 1 до " + numberA + " равно " + res1);
PrintRezult("Сумма чисел по Гаусу от 1 до " + numberA + " равно " + res2);