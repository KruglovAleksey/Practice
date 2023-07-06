// Задайте две матрицы. 
//Напишите программу, которая будет 
//находить произведение двух матриц.


int rows = 2;
int column = 2;

int[,] InitMatrix(int rows, int column)
{ 
    Random random = new Random();
    int[,] tmp = new int [rows, column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            tmp[i,j] = random.Next(1, 10);
        }
    }
    return tmp;
}

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    } 
}

int[,] СompositionMatrix(int[,] arr1, int[,] arr2, int[,] arr3)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                arr3[i,j] += arr1[i,k] * arr2[k,j];
            }
        }
    }
    return arr3;
}

int[,] matrix1 = InitMatrix(rows, column);
int[,] matrix2 = InitMatrix(rows, column);
int[,] matrix3 = new int[rows, column];
Print(matrix1);
Console.WriteLine();
Print(matrix2);
Console.WriteLine();
СompositionMatrix(matrix1, matrix2, matrix3);
Print(matrix3);


