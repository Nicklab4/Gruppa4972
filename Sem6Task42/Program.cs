// Задача №42
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

////////////////////////////////////////////////////
// Стандартные методы предыдущих заданий
////////////////////////////////////////////////////

// Метод ввода данных
int ReadData(string msg)
{
    System.Console.WriteLine(msg);
    int num = int.Parse(System.Console.ReadLine() ?? "0");
    return num;
}

// Метод вывода результата
void PrintRezult(string msg)
{
    System.Console.WriteLine(msg);
}

////////////////////////////////////////////////////
// Решение предложенное преподавателем
////////////////////////////////////////////////////

string DecToBin(int num)
{
    string line = "";

    while (num > 0)
    {
        line = num % 2 + line;
        num = num / 2;
    }

    return line;
}


int num = ReadData("Введите разбираемое число: ");

PrintRezult(DecToBin(num));