// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());

int a = num;
int index = 1;
while (a / 10 > 0)
{
    a = a / 10;
    index++;
}
if (index > 3)
{
    index = index - 3;
    int b = num;
    while (index > 0)
    {
        b = b / 10;
        index--;
    }
Console.WriteLine(b % 10);
}
else
{
    Console.WriteLine("В числе меньше 3 чисел ");
}
