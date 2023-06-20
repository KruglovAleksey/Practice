//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int res = 0;
for (int i = 0; number > 0; i++)
{
    res = res + number % 10;
    number = number / 10;
}

Console.Write($"Сумма цифр числа равна {res}");