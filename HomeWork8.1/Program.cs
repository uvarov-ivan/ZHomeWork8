// Задайте двумерный массив. Напишите программу, которая упорядочивает 
// по убыванию элементы каждой строки двумерного массива.

int[,] GenMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 10);
        }
    }
    return matrix;
}

int[,] OrderingRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowLength = matrix.GetLength(1);
        while (rowLength > 0)
        {
            for (int j = 0; j < rowLength - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1]) (matrix[i, j], matrix[i, j + 1]) = (matrix[i, j + 1], matrix[i, j]);
            }
            rowLength--;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] matrix = GenMatrix(5, 5);
PrintMatrix(matrix);
PrintMatrix(OrderingRows(matrix));
