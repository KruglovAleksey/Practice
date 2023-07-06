//Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.
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



int[,] matrix = InitMatrix(rows, column);
Print(matrix);
Console.WriteLine();

int[,] SortMatrix(int[,] arr)
{
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < column; j++)
    {
        for(int k = column - 1; k > 0; k--)
        {
            if (arr[i,k] < arr[i,k - 1])
            {
                int t = arr[i,k - 1];
                arr[i,k - 1] = arr[i,k];
                arr[i,k] = t;
            }
        }  
    } 
}
return arr;
}

SortMatrix(matrix);
Print(matrix);
