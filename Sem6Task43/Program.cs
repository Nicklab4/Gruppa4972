// №43 Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1,
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

// (Задание со звездочкой) Найдите площадь треугольника
// образованного пересечением 3 прямых

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

// Метод вывода результата
void PrintRezult(string msg)
{
    System.Console.WriteLine(msg);
}

// Метод нахождения растояния между точками из Sem3Task20
double Calc2DDistance(double x1, double x2, double y1, double y2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return res;
}

// Метод тестирования треугольника с заданными сторонами
// из  Sem6Task40
bool TriangleTest(double a, double b, double c)
{
    if (a + b < c)
        return false;
    if (b + c < a)
        return false;
    if (c + a < b)
        return false;

    return true;
}

/////////////////////////////////////////////
// Mетоды этого задания
/////////////////////////////////////////////

// Метод нахождения пересечения прямых
double[] PointIntersectLines(int k1, int b1, int k2, int b2)
{
    double[] point = new double[2];
    point[0] = Math.Round((double)((b2 - b1) / (k1 - k2)), 2);
    point[1] = Math.Round(k1 * point[0] + b1, 2);

    return point;
}

// Метод нахождения площади треугольника по трём сторонам
// формула Герона
double TriangleSquare(double a, double b, double c)
{
    double p = (a + b + c) / 2;
    return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
}


/////////////////////////////////////////////
// тело программы
/////////////////////////////////////////////

// Ввод данных
int k1 = ReadData("Введите коэффициент первой прямой: ");
int b1 = ReadData("Введите параметр B первой прямой: ");
int k2 = ReadData("Введите коэффициент второй прямой: ");
int b2 = ReadData("Введите параметр B второй прямой: ");
int k3 = ReadData("Введите коэффициент третьей прямой: ");
int b3 = ReadData("Введите параметр B третьей прямой: ");

// Вычисление точек пересечения
double[] point1 = PointIntersectLines(k1, b1, k2, b2);
double[] point2 = PointIntersectLines(k2, b2, k3, b3);
double[] point3 = PointIntersectLines(k1, b1, k3, b3);

// Вычисление сторон по точкам
double side1 = Calc2DDistance(point1[0], point2[0], point1[1], point2[1]);
double side2 = Calc2DDistance(point2[0], point3[0], point2[1], point3[1]);
double side3 = Calc2DDistance(point1[0], point3[0], point1[1], point3[1]);

// Проверка возможности треугольника и вывод площади треугольника
if (TriangleTest(side1, side2, side3))
{
    PrintRezult("Площадь треугольника образованного тремя пересекающимися линиями равна: "
                + "\n" + TriangleSquare(side1, side2, side3));
}
else
    PrintRezult("Что-то пошло не так");