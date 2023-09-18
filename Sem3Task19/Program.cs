// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да



///////////////////////////////////////////////////////////////////
// * Вариант через СЛОВАРЬ четырехзначных палиндромов
///////////////////////////////////////////////////////////////////

// 1) Ввести пятизначное число      -> ReadData()
//    Заполнить словать палиндромов -> FillDictionary()
// 2) Сравнить число со словарем    -> NumCompars()
// 3) Вывести результат             -> PrintRezult()

//вводим данные
int ReadData(string msg)
{
    System.Console.WriteLine(msg);
    int num = int.Parse(System.Console.ReadLine() ?? "0");
    return num;
}

// Метод заполнения словаря палиндромов
Dictionary<int, int> FillDictionary(Dictionary<int, int> dict)
{

    int n1, n2, temp;
    string numConstruct = "";

    for (int i = 10; i <= 99; i++)
    {
        n1 = i % 10;            // Первое число
        n2 = i / 10 % 10;       // Второе число
                                // Из первого и второго числа конструируем значение палиндрома
        numConstruct = n1.ToString() + n2.ToString() + n2.ToString() + n1.ToString();
        temp = int.Parse(numConstruct);

        dict.Add(temp, temp);   // Заносим в словарь
    }

    return dict;
}

// Метод сравнения числа со словарем
string NumCompars(int number, Dictionary<int, int> dict)
{
    string output = "";
    int value = 0;

    number = number / 1000 * 100 + number % 100;       // Выкусываем середину из числа

    if (dict.TryGetValue(number, out value))    // Производим сравнение получившегося числа 
    {                                           // со словарём и формируем возвращаемые строки
        output = " " + number + " -> да";       //
    }
    else
    {
        output = " " + number + " -> нет";
    }

    return output;
}

// Печатаем результат
void PrintRezult(string msg)
{
    System.Console.WriteLine(msg);
}



// тело программы

int testNum = ReadData("Введите пятизначное число: ");

Dictionary<int, int> dict = new Dictionary<int, int>();
dict = FillDictionary(dict);

PrintRezult(testNum + NumCompars(testNum, dict));







/////////////////////////////////////////////
// Решение задания посредством автотестов
/////////////////////////////////////////////
// // Внутри класса Answer напишите метод IsPalindrome,
// // который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

// // Метод должен проверить является ли число пятизначным,
// // в противном случае - вывести Число не пятизначное и False в следующей строке.

// // Для остальных чисел вернуть True или False.

// // 14212 -> False
// // 12821 -> True
// // 234322 -> Число не пятизначное
// //                      False

// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number){
//       // Введите свое решение ниже
//       if (number < 100000 && number > 9999)
//       {
//         int temp = number;
//         int[] nums = new int[5];
//         for (int i = 0; i < nums.Length; i++)
//         {
//             nums[i] = temp % 10;
//             temp /= 10;
//         }

//         if (nums[0]==nums[4] && nums[1]==nums[3])
//         {
//             System.Console.WriteLine(number + " -> ");
//             return true;
//         }
//         else
//         {
//             System.Console.WriteLine(number + " -> ");
//             return false;
//         }
//       }
//       else
//       {
//         System.Console.WriteLine(number + " -> Число не пятизначное");
//         return false;
//       }
//     }

//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 234322;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }