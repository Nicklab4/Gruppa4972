// Задача №9
// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.


void Variant1()
{
    System.Console.WriteLine("Способ 1");

    System.Random numberGenerator = new Random();
    int number = numberGenerator.Next(10, 100);
    System.Console.WriteLine(number);

    // 34/ 10 = 3
    int firstDigit = number / 10;
    // 34 % 10 = 4
    int secondDigit = number % 10;

    if (firstDigit > secondDigit)
        System.Console.WriteLine(firstDigit);
    else
        System.Console.WriteLine(secondDigit);
}

void Variant2()
{
    System.Console.WriteLine("Способ 2");

    System.Random numberGenerator1 = new Random();
    int number1 = numberGenerator1.Next(10, 100);
    System.Console.WriteLine(number1);

    System.Console.WriteLine(number1 / 10 > number1 % 10 ? number1 / 10 : number1 % 10);
}

void Variant3()
{
    System.Console.WriteLine("Способ 3");

    System.Random numberGenerator = new Random();
    int number = numberGenerator.Next(10, 100);
    System.Console.WriteLine(number);

    char[] digitChar = number.ToString().ToCharArray();

    System.Console.WriteLine((int)digitChar[0] > (int)digitChar[1] ? digitChar[0] : digitChar[1]);
}

Variant1();
Variant2();
Variant3();