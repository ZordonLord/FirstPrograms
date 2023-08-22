// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double sqrt = Math.Sqrt(5);
// double pow = Math.Pow(3, 5);
// Console.WriteLine(sqrt);
// Console.WriteLine(pow);

// double d = 5.09983461; // 5.09
// double dRound = Math.Round(d, 5, MidpointRounding.ToZero);
// Console.WriteLine(dRound);
// Console.WriteLine($"{d:F}");

double Distance(int coordX1, int coordY1, int coordX2, int coordY2)
{
    int side1 = coordX1 - coordX2;
    int side2 = coordY1 - coordY2;
    double distance = Math.Sqrt(side1 * side1 + side2 * side2);
    return distance;
}

Console.WriteLine("Введите координаты точки 1");
Console.Write("X: ");
int xCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2");
Console.Write("X: ");
int xCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(xCoordinate1, yCoordinate1, xCoordinate2, yCoordinate2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);

Console.WriteLine(resultRound);