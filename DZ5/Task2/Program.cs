/* Задайте одномерный массив, 
заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.*/

int[] array = new int[5];
int index = 1;
int sum = 0;

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,10);
    Console.Write($"{array[i]} ");
    if (index%2 != 0)
    {
        sum = sum + array[i];
    }
    index++;
}

Console.WriteLine("Сумма нечетных элементов массива =" + sum);