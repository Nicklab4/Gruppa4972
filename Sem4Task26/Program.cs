// Задача №26
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

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

int NumDigits(int num)
{
    int count=0;

    while(num > 0)
    {
        count++;
        num = num /10;
    }
    return count;
}

int LogDigits(int num)
{
    return Сonvert.;
}

int numberA = ReadData("Введите число:");
int res  = NumDigits(numberA);
PrintRezult("" + res );