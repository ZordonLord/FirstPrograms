// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr; 
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F2}, ");
        else Console.Write($"{arr[i]:F2}");
    }
    Console.WriteLine("]");
}

double MaxNumberArray(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}

double MinNumberArray(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}

double DifferenceMaxMin(double max, double min)
{
    double dif = max - min;
    return dif;
}

double[] array = CreateArrayRndDouble(5, 1, 99);
PrintArrayDouble(array);
double maxNumberArray = MaxNumberArray(array);
Console.WriteLine($"Max -> {maxNumberArray:F2}");
double minNumberArray = MinNumberArray(array);
Console.WriteLine($"Min -> {minNumberArray:F2}");
double differenceMaxMin = DifferenceMaxMin(maxNumberArray, minNumberArray);
Console.WriteLine($"Разница между Max и Min элементами массива -> {differenceMaxMin:F2}");