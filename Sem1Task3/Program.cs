// Задача №3
// Напишите программу, которая будет выдавать название дня
// недели по заданному номеру.

string[] dayOfWeek = new string[7];
dayOfWeek[0] = "Понедельник";
dayOfWeek[1] = "Вторник";
dayOfWeek[2] = "Среда";
dayOfWeek[3] = "Четверг";
dayOfWeek[4] = "Пятница";
dayOfWeek[5] = "Сббота";
dayOfWeek[6] = "Воскресенье";

Console.WriteLine("Вариант решения 1 - Введите номер дня недели");

int day = int.Parse(Console.ReadLine()); //?? "0";

Console.WriteLine(dayOfWeek[day - 1]);

////////////////////////////////
// Вариант решения 2
////////////////////////////////

System.Console.WriteLine("Вариант решения 2 - Введите номер");
int a = Convert.ToInt32(Console.ReadLine());
switch (a-1)
{
    case 0: System.Console.WriteLine("Пн"); break;
    case 1: System.Console.WriteLine("Вт"); break;
    case 2: System.Console.WriteLine("Ср"); break;
    case 3: System.Console.WriteLine("Чт"); break;
    case 4: System.Console.WriteLine("Пт"); break;
    case 5: System.Console.WriteLine("Сб"); break;
    case 6: System.Console.WriteLine("Вс"); break;

    default: System.Console.WriteLine("Неверные данные"); break;
}

////////////////////////////////
// Вариант решения 3
////////////////////////////////

System.Console.WriteLine("Вариант решения 3 - Enter day number");
int dayNum = int.Parse(Console.ReadLine());

if (dayNum == 1)
{
    System.Console.WriteLine("Monday");
}
else if (dayNum == 2)
{
    System.Console.WriteLine("Tuesday");
}
else if (dayNum == 3)
{
    System.Console.WriteLine("Wednesday");
}
else if (dayNum == 4)
{
    System.Console.WriteLine("Thursday");
}
else if (dayNum == 5)
{
    System.Console.WriteLine("Friday");
}
else if (dayNum == 6)
{
    System.Console.WriteLine("Saturday");
}
else if (dayNum == 7)
{
    System.Console.WriteLine("Sunday");
}
else 
{
    System.Console.WriteLine("Not day of week");
}


////////////////////////////////
// Вариант решения 4
// При помощи использования глобальных переменных
////////////////////////////////

System.Console.WriteLine("Вариант решения 4 - Enter day number");
int dayNum1 = int.Parse(Console.ReadLine());

string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum1));

System.Console.WriteLine(outDayOfWeek);