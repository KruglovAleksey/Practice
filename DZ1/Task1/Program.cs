//Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");

int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");

int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"первое число больше второго {num1} > {num2}");
}
else
{
    Console.WriteLine($"второе число больше первого {num1} < {num2}");
}