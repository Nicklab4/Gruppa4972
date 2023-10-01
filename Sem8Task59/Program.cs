// Задача 59:

// Задайтедвумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых
// расположен наименьший элемент массива.

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

int[] FindMinElem(int[,] matrix)
{
    int[] coord = new int[2];
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                coord[0] = i;
                coord[1] = j;
            }
        }
    }
    return coord;
}

int[,] Update2DArr(int[,] matrix, int[] coord)
{
    int[,] tempArr = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < coord[0] && j < coord[1])
                tempArr[i, j] = matrix[i, j];
            if (i > coord[0] && j < coord[1])
                tempArr[i - 1, j] = matrix[i, j];
            if (i < coord[0] && j > coord[1])
                tempArr[i, j - 1] = matrix[i, j];
            if (i > coord[0] && j > coord[1])
                tempArr[i - 1, j - 1] = matrix[i, j];
        }
    }

    return tempArr;
}

///////////////////////////////////////////////////////
// Решение преподавателя
///////////////////////////////////////////////////////
int[,] Update2DArr2(int[,] matrix, int[] coord)
{
    int[,] tempArr = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0, n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != coord[0])
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != coord[1])
                {
                    tempArr[m, n] = matrix[i, j];
                    n++;
                }
            }
            m++; n = 0;
        }
    }

    return tempArr;
}


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] array = Fill2Darray(row, column, 10, 100);

Print2DArray(array);
int[] coord = FindMinElem(array);
array = Update2DArr2(array, coord);
Print2DArray(array);