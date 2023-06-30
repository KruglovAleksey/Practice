//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.


Console.Write("Enter num rows :");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter num column :");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = InitMatrix(rows, column);

Print(matrix);

Console.WriteLine("Среднее арифметическое столбцов: ");


AverageValue(matrix);


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

void AverageValue (int[,] arr)
{
    double res = 0;
    for (int i = 0; i < column; i++)
    {   
        res = 0;
        for (int j = 0; j < rows; j++)
        {

            res = res + arr[j,i];
        }
        res = res / rows;
        Console.Write($"{Math.Round(res , 2)} ");
    } 
}