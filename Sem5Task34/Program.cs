// №34 Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1

// (со звездочкой) Отсортировать массив методом пузырька


////////////////////////////////////////////////////
//Стандартные методы предыдущих заданий
////////////////////////////////////////////////////

// Метод ввода данных
int ReadData(string msg)
{
    System.Console.WriteLine(msg);
    int num = int.Parse(System.Console.ReadLine() ?? "0");
    return num;
}

// Метод заполнения массива случайными числами определённого диапазона
int[] GenArray(int num, int lowBorder, int highBorder)
{
    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder + 1);
    }

    return array;
}

// Метод вывода массива
void PrintArray(int[] arr)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        System.Console.Write(arr[i] + ", ");
    }
    System.Console.Write(arr[arr.Length - 1] + " ]");
}

// Метод вывода результата
void PrintRezult(string msg)
{
    System.Console.WriteLine(msg);
}

/////////////////////////////////////////////
// методы этого задания
/////////////////////////////////////////////

// Метод подсчёта четных чисел
int CountEvn(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}


// Метод пузырьковой сортировки
void BubbleSort(int[] array)
{
    int temp;

    // основной цикл
    for (int i = 0; i < array.Length; i++)
    {
        // дополнительный цикл,
        // на каждом шаге основного цикла - дополнительный цикл короче на единицу,
        // так как максимальное значение вычисленное на предыдущем шаге оказывается
        // в конце массива и его считать больше не нужно
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j] > array[j + 1])    // если первый элемент больше второго
            {                               //
                temp = array[j + 1];        // меняем элементы местами
                array[j + 1] = array[j];    //
                array[j] = temp;            //
            }
        }
    }
}


/////////////////////////////////////////////
// тело программы
/////////////////////////////////////////////

int len = ReadData("Введите длинну массива:");
int[] arr = GenArray(len, 100, 999);

PrintArray(arr);
PrintRezult(" -> " + CountEvn(arr));
BubbleSort(arr);
PrintArray(arr);
