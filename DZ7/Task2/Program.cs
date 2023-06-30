// Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.


Console.Write("Enter number : ");
int number = Convert.ToInt32(Console.ReadLine());

int rows = 4;
int column = 4;

int[,] matrix = InitMatrix(rows, column);

Print(matrix);

Console.Write(SearchNumber(matrix, number));

int[,] InitMatrix(int rows, int column)
{ 
    Random random = new Random();
    int[,] tmp = new int [rows, column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            tmp[i,j] = random.Next(10, 31);
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

string SearchNumber(int[,] arr ,int num)
{ 
    string n = String.Empty;
   
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (arr[i,j] == num) 
            {
                n = $"Позиция элемента {num} = Строка {i+1} ,Столбец {j+1}"; 
                return n;
            }    
            else n = $"{num} -> Такого элемента нет в массиве ";
        }
    }
    return n;
}