// №36 Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0

// (со звездочкой) Найдите все пары в массиве и выведите пользователю


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
// Mетоды этого задания
/////////////////////////////////////////////
///

// Метод сумму элементов, стоящих на нечётных позициях.
int NegPosSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}


// Метод поиска пар в массиве
string PairArray(int[] array)
{

    string listPair = "";

    bool[] tempArr = new bool[array.Length];  // объявление временного bool массива

    for (int i = 0; i < tempArr.Length; i++)  // инициализация временного массива
        tempArr[i] = true;                    // значениями true

    // основной цикл
    for (int i = 0; i < array.Length; i++)
    {
        if (!tempArr[i]) continue;          // Если значению уже была найдена пара,
                                            // пропускаем данное значение

        // берём значение и выполняем поиск на совпадение,
        // при совпадении заносим в словарь
        // и помечаем в доп массиве это значение и значение пары false,
        // чтобы больше не проходить их
        for (int j = i + 1; j < array.Length; j++)
        {
            if (!tempArr[j] ) continue;     // осуществляем проверку на участие в сравнении  

            if (array[i] == array[j])       // если элементы совпадают
            {                               // заносим значения пар и позиции в список
                listPair = listPair + array[i] + "-" + array[j] + " - " + i + "-" + j + "\n";

                tempArr[i] = false;         // Отмечаем данные позиции 
                tempArr[j] = false;         // уже участвовавшими в сравнении
                break;                      // и прерываем выполнение доп цикла
            }
        }
    }

    return listPair;
}


/////////////////////////////////////////////
// тело программы
/////////////////////////////////////////////

int len = ReadData("Введите длинну массива:");
int x = ReadData("Введите нижнее значение чисел массива:");
int y = ReadData("Введите верхнее значение чисел массива:");
int[] arr = GenArray(len, x, y);

PrintArray(arr);
PrintRezult(" -> " + NegPosSum(arr));


PrintRezult(PairArray(arr));