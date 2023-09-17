// Задача №30
// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

//вводим данные
int ReadData(string msg)
{
    System.Console.WriteLine(msg);
    int num = int.Parse(System.Console.ReadLine() ?? "0");
    return num;
}

// 1) Длинна массива
// 2) Генерация массива GenArray
// 3) Печать массива PrintArray

int[] GenArray(int length)
{
    int[] arr = new int[length];
    Random rnd=new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(0,2);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arr.Length-1; i++)
    {
        System.Console.Write(arr[i] +", ");
    }
    System.Console.Write(arr[arr.Length - 1] + " ]");
}

int numberA = ReadData("Введите число:");
int[] res  = GenArray(numberA);
PrintArray( res );