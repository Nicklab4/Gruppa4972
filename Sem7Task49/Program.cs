// Задание 49
// Задайте двумерный массив, найдите элементы у которых оба
// индекса чётные и замените эти элементы на их квадраты

// Метод ввода данных
int ReadData(string msg)
{
    System.Console.WriteLine(msg);
    int num = int.Parse(System.Console.ReadLine() ?? "0");
    return num;
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

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void Modify2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] = (int)Math.Pow(matrix[i, j], 2);
        }
        System.Console.WriteLine();
    }
}


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] array = Fill2Darray(row, column, 10, 99);

Print2DArray(array);
Modify2DArray(array);
Print2DArray(array);