// Задача №40
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

bool TriangleTest(int a, int b, int c)
{
    if (a + b < c)
        return false;
    if (b + c < a)
        return false;
    if (c + a < b)
        return false;

    return true;
}