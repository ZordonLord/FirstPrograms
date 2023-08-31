// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Алгоритм нужно реализовать самостоятельно, встроенную функцию использовать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree(int num, int numDegree)
{
    int res = 1;
    for (int i = 0; i < numDegree; i++)
    {
        res = res * num;
    }
    return res;
}

Console.WriteLine("Введите число A:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B (степень):");
int numberBDegree = Convert.ToInt32(Console.ReadLine());

int result = Degree(numberA, numberBDegree);
Console.WriteLine($"Число {numberA} в степени {numberBDegree} -> {result}");