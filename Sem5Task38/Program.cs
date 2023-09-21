// №38
//  Задайте массив вещественных чисел. Найдите разницу между максимальным
//  и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6

// (со звездочкой) Отсортируйте массив методом вставки и методом подсчета,
// а затем найдите разницу между первым и последним элементом.
// Для задачи со звездочкой использовать заполнение массива целыми числами.


////////////////////////////////////////////////////
// Стандартные методы предыдущих заданий
////////////////////////////////////////////////////

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


/////////////////////////////////////////////
// Mетоды этого задания
/////////////////////////////////////////////

// Метод заполнения double массива случайными числами определённого диапазона
double[] GenArrayD(int num, int lowBorder, int highBorder)
{
    Random rnd = new Random();
    double[] array = new double[num];

    for (int i = 0; i < num; i++)
    {
        // Для того чтобы в масиве присутствовали не только дробные но и целые числа
        // случайным образом выбираем какое число будет дробным.
        if (rnd.Next(0, 2) == 0)
            // генерация случайного дробного числа
            array[i] = rnd.Next(lowBorder, highBorder) + Math.Round(rnd.NextDouble(), 2);
        else
            // случайная генерация целого числа
            array[i] = rnd.Next(lowBorder, highBorder + 1);
    }

    return array;
}

// метод сотртировки int массива вставкой
void InsertSort(int[] arr)
{
    int temp, j;                            // Объявляем вспомогательные переменные

    for (int i = 1; i < arr.Length; i++)    // Проходим по массиву
    {
        temp = arr[i];                      // В переменную temp помещаем значение
        j = i - 1;                          // устанавливаем счётчик второго цикла

        while (j >= 0 && arr[j] > temp)     // Пока предыдущая пременная больше значения temp
        {                                   //   
            arr[j + 1] = arr[j];            // Производим смещение вправо значений предыдущих ячеек
            j--;                            //
        }
        arr[j + 1] = temp;                  // Вставляем значение temp на освободившуюся позицию
    }
}

// Метод сортировки  int массива подсчётом
void CountingSort(int[] array, int min, int max)
{
    // Объявляем массив count размером от нижней до верхней границы
    int[] count = new int[max - min + 1];
    for (int i = 0; i < count.Length; i++)  //инициализация массива count нулями
    {
        count[i] = 0;
    }

    // Заполнение массива count
    for (int i = 0; i < array.Length; i++)  // Берём значение из основного массива и
    {                                       // увеличиваем на ед ячейку массива count
        count[array[i] - min]++;            // индекс которой равен значению ячейки arr,
    }                                       // с поправкой на нижнюю границу массива arr


    int indexArr = 0;                       // объявляем счётчик для массива arr

    // Проходим по массиву count
    for (int idxCount = min; idxCount < max + 1; idxCount++)
    {
        while (count[idxCount - min] > 0)   // Если значение ячейки count больше 0, 
        {                                   // заносим индекс массива count - idxCount
            array[indexArr] = idxCount;     // в массив arr,
            indexArr++;                     // увеличиваем счётчик массива arr,
            count[idxCount - min]--;        // при этом, уменьшаем значение ячейки count на ед
        }
    }
}


// Метод вывода  double массива
void PrintArrayD(double[] arr)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        System.Console.Write(arr[i] + " , ");
    }
    System.Console.Write(arr[arr.Length - 1] + " ]");
}


// Метод разницы между максимальным и минимальным элементом double массива.
double MinMaxDiffD(double[] arr)
{
    double min = arr[0];
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }

    return max - min;
}

// Метод разницы между максимальным и минимальным элементом int массива.
int MinMaxDiffI(int[] arr)
{
    return arr[arr.Length - 1] - arr[0];
}



/////////////////////////////////////////////
// тело программы
/////////////////////////////////////////////

int len = ReadData("Введите длинну массива:");
int x = ReadData("Введите нижнее значение чисел массива:");
int y = ReadData("Введите верхнее значение чисел массива:");
double[] arrD = GenArrayD(len, x, y);

System.Console.WriteLine();

PrintRezult("Массив Double и разница между min и max значением");
PrintArrayD(arrD);
PrintRezult(" -> " + MinMaxDiffD(arrD));

System.Console.WriteLine();

PrintRezult("Массив Int - сортировка вставкой");
int[] arrI = GenArray(len, x, y);
PrintArray(arrI);
InsertSort(arrI);
System.Console.WriteLine();
PrintArray(arrI);
PrintRezult(" -> " + MinMaxDiffI(arrI));

System.Console.WriteLine();

PrintRezult("Массив Int - сортировка подстчётом");
arrI = GenArray(len, x, y);
PrintArray(arrI);
CountingSort(arrI, x, y);
System.Console.WriteLine();
PrintArray(arrI);
PrintRezult(" -> " + MinMaxDiffI(arrI));