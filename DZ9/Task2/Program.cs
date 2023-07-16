// Задайте значения M и N. 
//Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.

Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

int GetRecSumm(int m, int n)
{
    if (m == n) return n;
    return m + GetRecSumm(m + 1, n);
    

}

if ((m > n) || (m < 0) || (n < 0)) Console.WriteLine("Число m должно быть больше чем n и они должны быть больше 0");
else Console.WriteLine($"Сумма натуральных числе от M до N = {GetRecSumm(m, n)}");