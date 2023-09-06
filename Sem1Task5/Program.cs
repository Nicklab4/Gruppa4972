// Задача №5
// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.


////////////////////////////////
// Вариант решения 1
////////////////////////////////


int a = int.Parse(Console.ReadLine()); //?? "0";

for (int i = -a; i <= a; i++)
{
    if (i == a)
        System.Console.Write(i);
    else
        System.Console.Write(i + ", ");
}

////////////////////////////////
// Вариант решения 2
////////////////////////////////

System.Console.WriteLine();

int n = int.Parse(Console.ReadLine());
int minusN = -n;

for (int i = minusN; i < n; i++)
{
    System.Console.Write(i.ToString() + ", ");
}
System.Console.Write(n.ToString());

////////////////////////////////
// Вариант решения 3
////////////////////////////////

System.Console.WriteLine();

int numN = int.Parse(Console.ReadLine());
int evNum = (-1) * numN;

while (evNum < numN)
{
    System.Console.Write(evNum + ", ");
    evNum++;
}
System.Console.Write(numN);