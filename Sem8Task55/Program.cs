// Задача 55:

// Задайте двумерный массив. Напишите программу, которая заменяет
// строки на столбцы. В случае, если это невозможно, программа
// должна вывести сообщение для пользователя.

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

bool TestArrayRotate(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
        return true;
    else
        return false;
}

void ArrayRotate(int[,] matrix)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i + i; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] array = Fill2Darray(row, column, 10, 100);

Print2DArray(array);
PrintRezult("Поворачивание массива: ");
if (TestArrayRotate(array))
{
    ArrayRotate(array);
    Print2DArray(array);
}
else
    PrintRezult("Данный массив нельзя перевернуть");