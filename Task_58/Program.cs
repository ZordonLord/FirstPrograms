// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write($"{matr[i, j],4}");
        }
        Console.WriteLine(" |");
    }
}

int[,] MultiplicationMatrix(int[,] matr1, int[,] matr2)
{
    int[,] multiplyMatrix = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < multiplyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiplyMatrix.GetLength(1); j++)
        {
            int sumProductsNumbers = 0;
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                sumProductsNumbers += matr1[i,k] * matr2[k, j];
            }
            multiplyMatrix[i,j] = sumProductsNumbers;
        }
    }
    return multiplyMatrix;
}

int[,] matrix1 = CreateMatrixRndInt(2, 2, 1, 9);
Console.WriteLine("Матрица 1:");
PrintArray(matrix1);
Console.WriteLine("Матрица 2:");
int[,] matrix2 = CreateMatrixRndInt(2, 2, 1, 9);
PrintArray(matrix2);
Console.WriteLine("Произведение матриц:");
if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    int[,] multiplicationMatrix = MultiplicationMatrix(matrix1, matrix2);
    PrintArray(multiplicationMatrix);
}
else Console.WriteLine("Количество столбцов первой матрицы не совпадает с количеством строк второй. Умножение невозможно.");