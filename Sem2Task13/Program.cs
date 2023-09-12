// Домашнее задание: №10
// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// * Сделать вариант для числа длиной до 10 цифр не используя char или string


long InputNum() // функция ввода числа
{
    System.Console.WriteLine("Введите число:");
    return long.Parse(System.Console.ReadLine() ?? "0"); ;
}

bool CheckNum(long num) // Функция проверки числа
{
    if (num < 100)
    {
        System.Console.WriteLine(num + " -> третьей цифры нет");
        return false;
    }

    if (num > 9_999_999_999)
    {
        System.Console.WriteLine(num + " в числе - больше 10 цифр");
        return false;
    }
    return true;
}


////////////////////////////////
// Вариант решения 1
////////////////////////////////
// Посредством строкового преобразования

string? line = System.Console.ReadLine();
char[] digits = line.ToCharArray();

System.Console.WriteLine(line.Length <= 2 ? line + " -> третьей цифры нет" :
    line + " -> " + digits[2]);




////////////////////////////////
// Вариант решения 2
////////////////////////////////
// Посредством разложения числа на составляющие

void Variant2(long num2)
{
    long temp2 = num2;                                  // Получаем число, например 98765

    int[] digitsArray = new int[10];                    // Инициализируем массив

    for (int i = digitsArray.Length - 1; i >= 0; i--)   // Цикл разложения числа
    {
        digitsArray[i] = (int)temp2 % 10;               // В результате получаем
        temp2 = temp2 / 10;                             // 0 0 0 0 0 9 8 7 6 5
        if (temp2 == 0) break;
    }

    for (int i = 0; i < digitsArray.Length; i++)        // Проверяем массив. Пока идут нули -
    {                                                   // игнорируем их. 
        if (!(digitsArray[i] == 0))                     // Как только встречается первая цифра - 
        {                                               // отображаем i+2 - 3й символ в ведённом числе
            System.Console.WriteLine(num2 + " -> " +
                digitsArray[i + 2]);
            break;                                      // и прерываем выполнение цикла
        }
    }
}



long num2 = InputNum();     // Вводим число

if (CheckNum(num2))         // Выполняем проверку
    Variant2(num2);         // Если проверка успешна - выполняем 2й вариант




////////////////////////////////
// Вариант решения 3
////////////////////////////////
// Самое оптимальное решение

void Variant3(long num3)
{
    long temp3 = num3;

    while (temp3 > 999)         // Цикл в котором мы уменьшаем число 
    {                           // до трёхзначного
        temp3 = temp3 / 10;     //
    }

    System.Console.WriteLine(num3 + " -> " + temp3 % 10);   // Выводим число и третий символ
}



long num3 = InputNum();     // Вводим число

if (CheckNum(num3))         // Выполняем проверку
    Variant3(num3);         // Если проверка успешна - выполняем 3й вариант
