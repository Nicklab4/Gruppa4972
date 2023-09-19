//Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и
// положительных элементов массива.

// 1) Метод генерации массива


int[] GenArray(int num, int LowBorder, int highBorder)
{
    
    int[] array = new int[num];
    
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder+1);
    }

    return array;
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

(int, int) NegativePositiveSum(int[] arr)
{
    int posSum = 0;
    int negSum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0)
            posSum += arr[i];
        else
            negSum += arr[i];
    }

    return (posSum, negSum);
}

int[] array = GenArray(12, -9,9);
PrintArray(array);
(int pos, int neg) sum = NegativePositiveSum(array);

System.Console.WriteLine("Сумма больше нуля: " + sum.pos + " Сумма чисел меньше нуля: " + sum.neg);