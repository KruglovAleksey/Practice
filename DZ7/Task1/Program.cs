// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Enter num rows :");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter num column :");
int column = Convert.ToInt32(Console.ReadLine());

double[,] matrix = InitMatrix(rows, column);

Print(matrix);

double[,] InitMatrix(int rows, int column)
{   
    Random rand = new Random();
    double[,] tmp = new double [rows, column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            tmp[i,j] = Math.Round(rand.NextDouble() + rand.Next(-9,10) , 2);
        }
    }
    return tmp;
}

void Print(double[,] arr)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    } 
}