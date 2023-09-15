// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

// int[,,] CreateArray3dRndInt(int rows, int columns, int depth, int min, int max)
// {
//     int[,,] matrix = new int[rows, columns, depth];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 matrix[i, j, k] = rnd.Next(min, max + 1);
//             }
            
//         }
//     }
//     return matrix;
// }

int[,,] CreateArray3dUniqueInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    int uniqueNum = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = uniqueNum++;
            }
            
        }
    }
    return matrix;
}

void PrintArray3d(int[,,] arr3d)
{
    for (int i = 0; i < arr3d.GetLength(0); i++)
    {
        for (int j = 0; j < arr3d.GetLength(1); j++)
        {
            for (int k = 0; k < arr3d.GetLength(2); k++)
            {
                Console.Write($"{arr3d[i, j, k],4}({i},{j},{k})");
            }
            Console.Write(" |");
        }
        Console.WriteLine();
    }
}

int[,,] array3d = CreateArray3dUniqueInt(2, 2, 2, 1, 9);
PrintArray3d(array3d);