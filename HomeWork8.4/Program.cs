// Напишите программу, которая заполнит спирально квадратный массив

int InputInt(string msg)
{
    System.Console.Write(msg + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenMatrixSnail(int num)
{
    int[,] matrix = new int[num, num];
    int count = 0;
    int startRow = 0;
    int startCol = 0;
    int finRow = num;
    int finCol = num;
    while (count < num * num)
    {
        for (int j = startCol; j < finCol; j++)
        {
            if (count == num * num)
            {
                break;
            }
            count++;
            matrix[startRow, j] = count;
        }
        startRow++;
        for (int i = startRow; i < finRow; i++)
        {
            if (count == num * num)
            {
                break;
            }
            count++;
            matrix[i, finCol - 1] = count;
        }
        finCol--;
        for (int j = finCol - 1; j >= startCol; j--)
        {
            if (count == num * num)
            {
                break;
            }
            count++;
            matrix[finRow - 1, j] = count;
        }
        finRow--;
        for (int i = finRow - 1; i >= startRow; i--)
        {
            if (count == num * num)
            {
                break;
            }
            count++;
            matrix[i, startCol] = count;
        }
        startCol++;
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
int[,] snailMatrix = GenMatrixSnail(InputInt("Введите размер массива"));
PrintMatrix(snailMatrix);
