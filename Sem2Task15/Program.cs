// Домашнее задание: №15
// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary


////////////////////////////////
// Общие функции
////////////////////////////////

int InputNum()              // Функция ввода числа
{
    System.Console.WriteLine("Введите число:");
    return int.Parse(System.Console.ReadLine() ?? "0"); ;
}

bool CheckNum(int numCN)    // Функция проверки числа
{
    if (numCN < 1 || numCN > 7)
    {
        System.Console.WriteLine(numCN + " Число меньше - 1, или больше - 7");
        return false;
    }

    return true;
}




////////////////////////////////
// Вариант решения 1
////////////////////////////////
// Через сравнение введённого числа

void Variant1(int numV1)
{
    System.Console.WriteLine(numV1 < 6 ? numV1 + " -> Да" : numV1 + " -> Нет");  // Вывод на консоль
}



int num = InputNum();      // Вводим число

if (CheckNum(num))         // Выполняем проверку
    Variant1(num);         // Если проверка успешна - выполняем 1й вариант



////////////////////////////////
// Вариант решения 2
////////////////////////////////
// Вариант решения с применением Dictionary

void Variant2(int numV2)
{
    Dictionary<int, string> dayOfWeek =                 // Инициализируем Словарь
    new Dictionary<int, string>();

    // Add some elements to the dictionary. There are no
    // duplicate keys, but some of the values are duplicates.
    dayOfWeek.Add(1, "будний день - Понедельник");      // Заполняем словарь
    dayOfWeek.Add(2, "будний день - Вторник");
    dayOfWeek.Add(3, "будний день - Среда");
    dayOfWeek.Add(4, "будний день - Четверг");
    dayOfWeek.Add(5, "будний день - Пятница");
    dayOfWeek.Add(6, "выходной день - Суббота");
    dayOfWeek.Add(7, "выходной день - Воскресенье");

    System.Console.WriteLine(numV2 + " -> " + dayOfWeek[numV2]);  // Вывод на консоль
}



int num2 = InputNum();      // Вводим число

if (CheckNum(num2))         // Выполняем проверку
    Variant2(num2);         // Если проверка успешна - выполняем 2й вариант
