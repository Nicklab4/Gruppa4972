// Задача 69

// Напишите программу котрая будет принимать два числа A и B,
// возведите A в степень B

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





long RecPow(int a, int b)
{
    long res = 1;
    if (b <= 0)
        return res = 1;
    else
        res = a * RecPow(a, b - 1);
    return res;
}

long MyPow(int a, int b)
{
    long res = 1;
    if (b == 2)
        return a * a;
    if (b == 1)
        return a;
    if (b % 2 == 0)
        return res = MyPow(a, b / 2) * MyPow(a, b / 2);
    else
        return res = MyPow(a, b / 2) * MyPow(a, b / 2 + 1);
}


int b = ReadData("Введите степень");

DateTime d1 = DateTime.Now;
long res = RecPow(2, b);
PrintRezult(res + "\n" + (d1 - DateTime.Now));

DateTime d2 = DateTime.Now;
long res2 = MyPow(2, b);
PrintRezult(res + "\n" + (d2 - DateTime.Now));
