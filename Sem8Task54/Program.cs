// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки
// двумерного массива.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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


// Соритровка строк двумерного массива методом частотного массива
void RowSortingArray(int[,] matrix, int min, int max)
{
    int indexArr; // Объявляем вспомогательный счётчик

    int[] count = new int[max - min + 1];       // Объявляем частотный массив - count
    for (int i = 0; i < count.Length; i++)      // Инициализация массива count нулями
    {
        count[i] = 0;
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Проходим по строке и добавляем значения в частотный массив
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            count[matrix[i, j] - min]++;
        }

        indexArr = 0;                           // обнуляем счётчик для массива matrix

        // Проходим по массиву count и перезаполняем строку массива matrix
        for (int idxCount = min; idxCount < max + 1; idxCount++)
        {
            while (count[idxCount - min] > 0)   // Если значение ячейки count больше 0, 
            {                                   // заносим индекс массива count - idxCount
                matrix[i, indexArr] = idxCount; // в массив matrix,
                indexArr++;                     // увеличиваем счётчик массива matrix,
                count[idxCount - min]--;        // при этом, уменьшаем значение ячейки count на ед
            }
        }
        // В конце? не требуется обнулять массив Count, он и так будет содержать нули
    }
}

//////////////////////////////////////////////////////////////
/// Тело программы
//////////////////////////////////////////////////////////////


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] array = Fill2Darray(row, column, 10, 100);

Print2DArray(array);
RowSortingArray(array, 10, 100);
PrintRezult("Отсортированный по строкам массив:");
Print2DArray(array);
