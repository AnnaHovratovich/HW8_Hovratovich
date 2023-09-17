// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


using System.Diagnostics.CodeAnalysis;

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


int[,] MatrixMultiplication (int [,] firstMatrix, int[,]secondMatrix)
{
    int [,] matrixMultiplication= new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int k = 0, n=0; k < firstMatrix.GetLength(1); k++, n++)
            {
                    matrixMultiplication[i,j]+= firstMatrix[i,k]*secondMatrix[n,j];
            }  
            
        }
    }
    
    return matrixMultiplication;
}


void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine();
    }
}


int[,] matrix1 = CreateMatrixRndInt(2, 3, 0, 9);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt(3, 3, 0, 9);
PrintMatrix(matrix2);
Console.WriteLine();
if (matrix1.GetLength(1)==matrix2.GetLength(0))
{
    int[,] matrixMult=MatrixMultiplication(matrix1, matrix2);
    PrintMatrix(matrixMult);
}
else Console.WriteLine($"Не соблюдается условие умножения матриц!");
