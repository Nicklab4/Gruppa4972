//Заадча № 39
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1)
// менять числа местами в исходном массиве; 2) создать
// новый массив и в него записать перевёрнутый исходный
// массив по элементам.

// Метод генерации массива и заполнение е го случайными числами.
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
    System.Console.WriteLine();
}

// метод переворачивания массива
int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[arr.Length - 1 - i] = arr[i];
    }
    return outArr;
}

void SwapArray(int[] arr)
{
    // int temp;

    for (int i = 0; i < arr.Length / 2; i++)
    {
        // Данная операция является декорацией закоментированных операций
        (arr[arr.Length - 1 - i], arr[i]) = (arr[i], arr[arr.Length - 1 - i]);

        // temp = arr[i];
        // arr[i] = arr[arr.Length - 1 - i];
        // arr[arr.Length - 1 - i] = temp;
    }
}

int[] arr = GenArray(15, 1, 100);
int[] swapArr = SwapNewArray(arr);
System.Console.WriteLine("Исходный массив: ");
PrintArray(arr);
System.Console.WriteLine("Перевернутый массив: ");
SwapArray(arr);
PrintArray(arr);
System.Console.WriteLine("Перевернутый массив: ");
PrintArray(swapArr);