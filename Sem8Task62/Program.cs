// Задача 62.

// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int[,] FillSpiral2DArray(int x, int y)
{
    int[,] arr = new int[x, y];             // Задаём основной массив
    bool[,] shadowArr = new bool[x, y];     // Задаём теневой массив в котором 
                                            // отмечаем заполненнные ячейки
    int direction = 1;                      // Первоначальное направление движения

    int i = 0, j = 0;                       // Индексы основного и вспомогательного массивов

    // Основной проход равный количеству ячеек - x * y
    for (int count = 0; count < x * y; count++)
    {
        arr[i, j] = count + 1;              // Задаём значение основного массива
        shadowArr[i, j] = true;             // Помечаем заполненную ячейку во вспомогательном массиве

        if (direction == 1)
        {
            if (j != y - 1 && !shadowArr[i, j + 1]) // Если индекс не вышел за пределы массива
                j++;                                // и следующая ячейка в теневом массиве не заполнена
                                                    // увеличиваем индекс по направлению движения
            else
            {                                       // В противном случае:
                direction = 2;                      // меняем направление движения,
                i++;                                // изменяем соответствующий индекс,
                continue;                           // и принудительно выходим из этой итерации цикла,
            }                                       // чтобы не сработали следующие условия
        }

        if (direction == 2)
        {
            if (i != x - 1 && !shadowArr[i + 1, j])
                i++;
            else
            {
                direction = 3;
                j--;
                continue;
            }
        }

        if (direction == 3)
        {
            if (j > 0 && !shadowArr[i, j - 1])      // Если индекс не вышел за пределы массива
                j--;                                // и следующая ячейка в теневом массиве не заполнена
                                                    // уменьшаем индекс по направлению движения
                
            else
            {
                direction = 4;
                i--;
                continue;
            }
        }

        if (direction == 4)
        {
            if (i > 0 && !shadowArr[i - 1, j])
                i--;
            else
            {
                direction = 1;
                j++;
                continue;
            }
        }
    }

    return arr;
}

//////////////////////////////////////////////////////////////
/// Тело программы
//////////////////////////////////////////////////////////////


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] array = FillSpiral2DArray(row, column);

Print2DArray(array);