// Задача №22
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

//вводим данные
int ReadData(string msg)
{
    System.Console.WriteLine(msg);
    int num = int.Parse(System.Console.ReadLine() ?? "0");
    return num;
}

string BuildLine(int x)
{
    string res = string.Empty;
    string res2 = string.Empty;

    for (int i = 1; i <= x; i++)
    {
        res = res + i + " ";
        res2 = res2 + Math.Pow(i, 2) + " ";
    }

    return res + "\n" + res2;
}

// Печатаем результат
void PrintRezult(string msg)
{
    System.Console.WriteLine(msg);
}

int num = ReadData("Введите номер: ");

PrintRezult(BuildLine(num));