/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27 
5 -> 1, 8, 27, 64, 125*/

void GetCube(int n)
{   
    int k = 0;
    for(int i = 1; i <= n; i++)
    {
        k = i*i*i;
        Console.Write(" " + k);
    }
}

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
GetCube(n);




/*int k = 0;
for(int i = 1; i <= n; i++)
{
    k = i*i*i;
    Console.Write(" " + k);
}*/

