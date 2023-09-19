// Задача №35
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


int[] GenArray(int num, int lowBorder, int highBorder)
{
    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder + 1);
    }

    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        System.Console.Write(arr[i] + ", ");
    }
    System.Console.Write(arr[arr.Length - 1] + " ]");
}

int CountElem(int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 &&array[i] <= 99  )
        count++;
    }
    return count;
}

void PrintRezult(string msg)
{
    System.Console.WriteLine(msg);
}

int[] arr = GenArray(123, -200, 200);
PrintArray(arr);
PrintRezult("количество элементов массива, значения которых лежат в отрезке [10,99]: " + CountElem(arr));

