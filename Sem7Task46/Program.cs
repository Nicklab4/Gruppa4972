// Задание 46
// Задайте двумерный массив размером m*n, заполненный случайными целыми числами.

// Метод ввода данных
int ReadData(string msg)
{
    System.Console.WriteLine(msg);
    int num = int.Parse(System.Console.ReadLine() ?? "0");
    return num;
}

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

void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] colors = new ConsoleColor[] {ConsoleColor.Black, ConsoleColor.Blue,
                            ConsoleColor.Cyan, ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,
                            ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta,
                            ConsoleColor.DarkRed, ConsoleColor.DarkYellow, ConsoleColor.Gray,
                            ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Red,
                            ConsoleColor.White, ConsoleColor.Yellow};

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.ForegroundColor = colors[new System.Random().Next(0, 16)];
            System.Console.Write(matrix[i, j] + " ");
            System.Console.ResetColor();
        }
        System.Console.WriteLine();
    }
}


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

Print2DArrayColor(Fill2Darray(row, column, 10, 99));