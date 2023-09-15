// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int colunns, int min, int max)
{
    int[,] matrix = new int[rows, colunns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],6}");
        }
        Console.WriteLine(" |");
    }
}

void ArrangeLinesOfMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // проходим по строкам матрицы.
    {
        for (int countSorted = 0; countSorted < matr.GetLength(1) - 1; countSorted++) // уменьшаем диапазон сортировки ячеек строки.
        {
            for (int j = 0; j < matr.GetLength(1) - 1 - countSorted; j++) // проходим по текущему диапазону сортировки ячеек строки.
            {
                if (matr[i, j] < matr[i, j + 1]) // проверка меньшего значения для смещения к концу строки.
                {
                    int temp = matr[i, j];
                    matr[i, j] = matr[i, j + 1];
                    matr[i, j + 1] = temp;
                }
            }
        }
    }
}

int[,] MatrixRndInt = CreateMatrixRndInt(4, 5, -9, 9);
PrintArray(MatrixRndInt);
Console.WriteLine();
ArrangeLinesOfMatrix(MatrixRndInt);
PrintArray(MatrixRndInt);