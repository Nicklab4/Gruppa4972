// Задача №20
// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.

// 1) ReadData()
// 2) Calc2DDistance()
// 3) PrintResult()

double Calc2DDistance(int x1, int x2, int y1, int y2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return res;
}