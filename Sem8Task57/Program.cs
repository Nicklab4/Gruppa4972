// Задача 57:
// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько
// раз встречается элемент входных данных.

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

void Print1DArray(int[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        System.Console.Write(matrix[i] + "\t");
    }
}

int[] FreqDict(int[,]matrix, int length)
{
    int[] dictArr = new int[length];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            dictArr[matrix[i,j]]++;    
        }        
    }
    return dictArr;
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] array = Fill2Darray(row, column, 1, 10);

Print2DArray(array);
int[] frqDict= FreqDict(array, 10);
Print1DArray(frqDict);
