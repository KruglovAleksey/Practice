// Напишите программу вычисления функции 
//Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

int GetRecAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return GetRecAkkerman(m - 1, 1);
    if (m > 0 && n > 0) return GetRecAkkerman(m - 1, GetRecAkkerman(m, n - 1));
    return GetRecAkkerman(m,n);
}
if ((m < 0) || (n < 0)) Console.WriteLine("Число m и n должны быть больше 0");
else Console.WriteLine(GetRecAkkerman(m, n));