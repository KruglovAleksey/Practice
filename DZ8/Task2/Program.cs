// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.

Console.Write("Enter num rows :");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter num column :");
int column = Convert.ToInt32(Console.ReadLine());

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
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    } 
}

void MinSumLine (int[,] arr)
{
    int[] SumLine = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            SumLine[i]+= arr[i,j];
        }
    }
    int linemin = 0;
    for (int i = 0; i < rows; i++)
    {
        if (SumLine[linemin] > SumLine[i])linemin = i;
    }
    Console.Write($"строка с наименьшей суммой элементов: {linemin + 1}");
}



if (rows == column)
{
    Console.WriteLine("Количество столбцов должно отличаться от количества строк");
}
else
{
    int[,] matrix = InitMatrix(rows, column);
    Print(matrix);
    Console.WriteLine();
    MinSumLine(matrix);
}