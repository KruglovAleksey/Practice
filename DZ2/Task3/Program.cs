// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1:
    Console.WriteLine("Не выходной");
    break;
    case 2:
    Console.WriteLine("Не выходной");
    break;
    case 3:
    Console.WriteLine("Не выходной");
    break;
    case 4:
    Console.WriteLine("Не выходной");
    break;
    case 5:
    Console.WriteLine("Не выходной");
    break;
    case 6:
    Console.WriteLine("Выходной");
    break;
    case 7:
    Console.WriteLine("Выходной");
    break;
    default:
    Console.WriteLine("Введенное число не входит в диапазон от 1 до 7");
    break;
}

