//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int GetRes(int num, int st)
{
    int res = num;
    for (int i = 0; i < st - 1; i++)
    {
        res = res * num;
    }
    return res;
}

Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

int pow = GetRes(a, b);
Console.Write($"Число {a} в степени {b} = {pow}");


