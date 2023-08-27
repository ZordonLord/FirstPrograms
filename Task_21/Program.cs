// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int coordX1, int coordY1, int coordZ1, int coordX2, int coordY2, int coordZ2)
{
    int side1 = coordX1 - coordX2;
    int side2 = coordY1 - coordY2;
    int side3 = coordZ1 - coordZ2;
    double distance = Math.Sqrt(side1 * side1 + side2 * side2 + side3 * side3);
    return distance;
}

Console.WriteLine("Введите координаты точки 1");
Console.Write("X: ");
int xCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoordinate1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2");
Console.Write("X: ");
int xCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoordinate2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(xCoordinate1, yCoordinate1, zCoordinate1, xCoordinate2, yCoordinate2, zCoordinate2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);

Console.WriteLine(resultRound);