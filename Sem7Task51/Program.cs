// Задача 51
// Задайте двумерный массив, найдите сумму элементов
// находищихя на главной диагонали с индексами 0.0 1.1

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

// Метод запонения массива случайными числами
int[,] Fill2Darray(int countRow, int countColumn, int lowBorder, int highBorder)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rnd.Next(lowBorder, highBorder);
        }

    }

    return array2D;
}

// Метод печати массива
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                System.Console.ForegroundColor = ConsoleColor.Red;
                System.Console.Write(matrix[i, j] + "\t");
                System.Console.ResetColor();
            }
            else
                System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

// Метод суммирования главной диагонали
int SumDiagonalArray(int[,] matrix)
{
    int count = 0;
    int sum = 0;
    if (matrix.GetLength(0) <= matrix.GetLength(1))
        count = matrix.GetLength(0);
    else
        count = matrix.GetLength(1);

    for (int i = 0; i < count; i++)
    {
        sum = sum + matrix[i, i];
    }

    return sum;
}


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] array = Fill2Darray(row, column, 10, 99);

Print2DArray(array);
PrintRezult("Сумма значений главной диагонали равна: " + SumDiagonalArray(array));
