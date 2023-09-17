// Задача №28
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

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

long Factorial(int num)
{
    long res = 1;
    for (int i = 1; i <= num; i++)
    {
        res = res * i;
    }

    return res;
}

int numberA = ReadData("Введите число:");
long res  = Factorial(numberA);
PrintRezult("" + res );