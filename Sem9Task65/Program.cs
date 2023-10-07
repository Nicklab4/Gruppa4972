// Задача 65 

// Задайте чисол M и N, напишите программу которая найдёт все натуральные 
// элементы в промежутке от M до N

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


string RecMN(int numM, int numN)
{
    string str = "";

    if (numM <= numN)
        return numM + " " + RecMN(numM + 1, numN);
    else
        return str;
}


int m = ReadData("Введите число M : ");
int n = ReadData("Введите число N : ");

PrintRezult((m > n)?RecMN(n, m) : RecMN(m, n));
