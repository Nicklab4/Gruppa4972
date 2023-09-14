// Задача №18
// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

// 1) Ввести номер четверти -> ReadData()
// 2) Ответить на вопрос    -> ??
// 3) Вывести результат     -> PrintRezult()

//вводим данные
int ReadData(string msg)
{
    System.Console.WriteLine(msg);
    int num = int.Parse(System.Console.ReadLine() ?? "0");
    return num;
}



string QuarterBorderAsk(int numQuarter)
{
    if (numQuarter == 1) return "X > 0 , Y > 0";
    if (numQuarter == 2) return "X < 0 , Y > 0";
    if (numQuarter == 3) return "X < 0 , Y < 0";
    if (numQuarter == 4) return "X > 0 , Y < 0";

    return "";
}

// Печатаем результат
void PrintRezult(string msg)
{
    System.Console.WriteLine(msg);
}

int qarterNum = ReadData("Введите номер четверти: ");

PrintRezult("Возможные значения: " + QuarterBorderAsk(qarterNum));