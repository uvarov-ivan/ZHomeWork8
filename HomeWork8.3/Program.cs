// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц

int[,] GenMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        int[,] resaltMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < resaltMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resaltMatrix.GetLength(1); j++)
            {
                int resaltElement = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    resaltElement += (matrix1[i, k] * matrix2[k, j]);
                }
                resaltMatrix[i, j] = resaltElement;

            }
        }
        return resaltMatrix;
    }
    else
    {
        System.Console.WriteLine("Такие матрицы перемножить нельзя.");
        return new int[1, 1];
    }

}

int[,] matrixA = GenMatrix(2, 3);
int[,] matrixB = GenMatrix(3, 2);
PrintMatrix(matrixA);
PrintMatrix(matrixB);
PrintMatrix(ProductMatrix(matrixA, matrixB));

