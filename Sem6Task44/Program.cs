// Задача №44
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

void PrintFibNum(int num)
{
    int first = 0;
    int second = 1;
    System.Console.Write(first +", "+ second + ", ");

    int temp;

    for (int i = 0; i < num-2; i++)
    {
        System.Console.Write( first+second + ", ");
        temp = first+ second;
        first = second;
        second = temp;
    }
}

PrintFibNum(20);