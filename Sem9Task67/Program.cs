// // Задача 67

// Задача принимает на вход число N и возврвщвет сумму его чисел.

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





int SumDigitRec(int n)
{
    if (n == 0)
        return 0;
    else
        return n % 10 + SumDigitRec(n / 10);
}



int b = ReadData("Введите число");

PrintRezult("Сумма составляющих чисел = " + SumDigitRec(b));