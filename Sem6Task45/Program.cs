// Задача №45
// Напишите программу, которая будет создавать копию заданного
// одномерного массива с помощью поэлементного копирования.

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

// Метод поэлементного копирования массива
int[] CopyToNewArray(int[] arr)
{
    int[] arr2 = new int[arr.Length];

    for (int i = 0; i < arr2.Length; i++)
    {
        arr2[i] = arr[i];
    }

    return arr2;
}

int[] arr1 = GenArray(15, 1, 100);
int[] arr2 = CopyToNewArray(arr1);
System.Console.WriteLine("Исходный массив: ");
PrintArray(arr1);
System.Console.WriteLine("Скопированный массив: ");
PrintArray(arr2);