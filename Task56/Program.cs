// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2   
// 5 9 2 3   
// 8 4 2 4   
// 5 2 6 7   
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


int[] SumElementsInRow (int[,] matrix)
{
    int [] sumArray=new int [matrix.GetLength(0)];
    int sum=0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum+=matrix[i,j];        
        }
        sumArray[i]=sum;
        sum=0;
            
    }
    return sumArray;
}


// void PrintArray(int[] sumArray) 
// { 
//     Console.Write("["); 
//     for (int i = 0; i < sumArray.Length; i++) 
//     { 
//         if (i < sumArray.Length - 1) Console.Write($"{sumArray[i]}, "); 
//         else Console.Write($"{sumArray[i]}"); 
//     } 
//     Console.Write("]"); 
// }


int SmallestSum (int [] sumArray)
{
    int min=sumArray[0];
    int indexMin=0;
    for(int i = 1; i < sumArray.Length; i++)
    {
            if (sumArray[i] < min)
            {
                min=sumArray[i];
                indexMin=i;
            }    
    }
    return indexMin;

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


int[,] matrix = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();
int[] arr=SumElementsInRow (matrix);
// PrintArray (arr);
// Console.WriteLine();
int indexMinimalSum=SmallestSum(arr)+1;
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indexMinimalSum} строка");