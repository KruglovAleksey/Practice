// Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

int GetRecNum(int num)
{   
    Console.Write(num + " ");
    if (num == 1) return 1; 
    return 1 + GetRecNum(num - 1);
    
      
}

if (n > 0)
{
    GetRecNum(n);
}
else Console.WriteLine("Введите число N > 0");
