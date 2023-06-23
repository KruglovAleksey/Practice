/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/

double[] array = new double[5];
Random rand = new Random();

for(int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(rand.NextDouble()+rand.Next(0,10),2,MidpointRounding.ToZero);
    Console.Write($"{array[i]} ");
}
double max = array[0];
double min = array[0];
for(int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
    if (min > array[i])
    {
        min = array[i];
    }
}

Console.WriteLine();
Console.WriteLine($"Максимальный элемент массива = {Math.Round(max,2,MidpointRounding.ToZero)}");
Console.WriteLine($"Минимальный элемент массива = {Math.Round(min,2,MidpointRounding.ToZero)}");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {Math.Round(max - min,2,MidpointRounding.ToZero)}");