// Задача №33
// Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.


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

int ReadData(string msg)
{
    System.Console.WriteLine(msg);
    int num = int.Parse(System.Console.ReadLine() ?? "0");
    return num;
}

int FindElem(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return i+1;
        }

    }
    return -1;
}

void PrintRezult(string msg)
{
    System.Console.WriteLine(msg);
}

int[] arr = GenArray(12, -9, 9);
PrintArray(arr);

int elem = ReadData("Введите число которое ищем в массиве: ");

PrintRezult("Искомое число находится на "+ FindElem(arr, elem)+ " месте");