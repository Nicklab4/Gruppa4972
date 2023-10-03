// Задача 56:
// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

//////////////////////////////////////////////////////////////
/// Методы предыдущих занятий
//////////////////////////////////////////////////////////////

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
            // Выделение диагонали массива красным, для красоты
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

//////////////////////////////////////////////////////////////
/// Методы текущего задания 
//////////////////////////////////////////////////////////////

int FindMinSumOfRow(int[,] matrix)
{
    // объявляем переменные в которых будет храниться сумма
    // и номер строки с минимальным значением.
    int sum, minRow;

    // Объявляем временный массив в котором будут храниться суммы строк.
    int[] tempArr = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;                 // При переходе на новую строку - обнуляем сумму.

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j]; // Суммируем значения строки.
        }

        tempArr[i] = sum;        // Заносим итоговую сумму во временный массив.
    }

    // Производим поиск минимального значения в  массиве tempArr и
    // запоминиаем индекс этого значения.
    // В данном цикле sum выполняет роль просто временной переменной.
    sum = tempArr[0];           
    minRow = 0;

    for (int i = 0; i < tempArr.Length; i++)
    {
        if (sum > tempArr[i])
        {
            sum = tempArr[i];
            minRow = i;
        }
    }

    // Возвращаем найденный индекс и увеличиваем его на единицу,
    // так как в человекочитаемом списке - нет нулевых строк.
    return minRow + 1; 
}


//////////////////////////////////////////////////////////////
/// Тело программы
//////////////////////////////////////////////////////////////


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] array = Fill2Darray(row, column, 10, 100);

Print2DArray(array);
PrintRezult("Строка с наименьшей суммой - " + FindMinSumOfRow(array));
