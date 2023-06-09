// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число n: ");

double n = double.Parse(Console.ReadLine());

if (n > 1)
{   
    for (int num = 2; num<n; num = num + 2)
    {
        Console.Write($"{num} ");
    }
}
else
{
    Console.Write("В диапазоне от 1 до n нет четных чисел");
}