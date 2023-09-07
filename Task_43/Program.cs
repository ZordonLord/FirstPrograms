// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] FindPointCross(double b1, double k1, double b2, double k2)
{
    double[] coord = new double[2];
    coord[0] = (b2 - b1) / (k1 - k2);
    coord[1] = k1 * coord[0] + b1;
    return coord;
}

Console.WriteLine("Введите b1:");
double b1Num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1:");
double k1Num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2:");
double b2Num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2:");
double k2Num = Convert.ToDouble(Console.ReadLine());

double[] findPointCross = FindPointCross(b1Num, k1Num, b2Num, k2Num);
Console.WriteLine($"{findPointCross[0]}; {findPointCross[1]}");