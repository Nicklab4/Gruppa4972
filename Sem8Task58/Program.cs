// Задача 58:
// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

// Метод выводящий на экрам значение двух одинаковых по размеру матриц
void Print2xMatrix(int[,] matrixA, int[,] matrixB)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)  // Выводим строку первого массива
        {
            System.Console.Write(matrixA[i, j] + "\t");
        }
        System.Console.Write("|\t");                    // Рисуем сепаратор
        for (int j = 0; j < matrixB.GetLength(1); j++)  // Выводим строку второго массива
        {
            System.Console.Write(matrixB[i, j] + "\t");
        }
        System.Console.WriteLine();                     // Перевод строки
    }
}


// Метод умножения матриц
int[,] MatrixMultiply(int[,] matrixA, int[,] matrixB)
{
    // Формируем матрицу С со сторонами X матрицы A и стороной Y матрицы B.
    // Предполагается, что стороны Y матрицы A и сторона X матрицы B - равны.
    // Если необходимо, проверку этого равенства можно реализовать в отдельном методе
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];


    // Проходим по матрице C
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            // И суммируем произведения значений в строках матрицы А
            // на значения в столбцах матрицы B
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return matrixC;
}


//////////////////////////////////////////////////////////////
/// Тело программы
//////////////////////////////////////////////////////////////


int rowColumn = ReadData("Введите размер матрицы X*X: ");

int[,] matrixA = Fill2Darray(rowColumn, rowColumn, 1, 10);
int[,] matrixB = Fill2Darray(rowColumn, rowColumn, 1, 10);

PrintRezult("Вывод матриц: ");
Print2xMatrix(matrixA, matrixB);
PrintRezult("Итог умножения матриц: ");
Print2DArray(MatrixMultiply(matrixA, matrixB));

//////////////////////////////////////////////////////////////
/// Проверка умножения прямоугольных матриц
//////////////////////////////////////////////////////////////

PrintRezult("Тест прямоугольных матриц 3х4 и 4х2");
PrintRezult("Матрица 3х4");
matrixA = Fill2Darray(3, 4, 1, 10);
Print2DArray(matrixA);
PrintRezult("Матрица 4х2");
matrixB = Fill2Darray(4, 2, 1, 10);
Print2DArray(matrixB);
PrintRezult("Итог умножения матриц");
Print2DArray(MatrixMultiply(matrixA, matrixB));
