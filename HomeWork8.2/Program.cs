// Задайте прямоугольный двумерный массив. Напишите программу, 
// будет находить строку с наименьшей суммой элементов.

int[,] GenMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(-9, 10);
        }
    }
    return matrix;
}

int MinSumRow(int[,] matrix)
{
    int minSum = 2147483647;
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }
        if (rowSum < minSum)
        {
            minSum = rowSum;
            minRow = i;
        }
    }
    return minRow;
}

void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]}\t");
        }
        System.Console.WriteLine();
    }  
    System.Console.WriteLine();
}

void PrintMinRow (int [,] matrix, int minRow)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write($"{matrix[minRow,j]}\t");
    }  
    System.Console.WriteLine();
}

int[,] matrix = GenMatrix (4,4);
PrintMatrix(matrix);
PrintMinRow(matrix, MinSumRow(matrix));
