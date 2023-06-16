/*Напишите программу, которая принимает 
на вход пятизначное число и проверяет, является ли 
оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

string GetPalindrom (int n)
{
    int index = 1;
    int a = n;
    while (a / 10 > 0)
    {
        a = a / 10;
        index++;
    }

    if (index != 5)
    {
        return"Введенное число не пятизначное.";
    }
    else
    {
        if (n/10000 == n%10 && (n/1000)%10 == (n/10)%10)
        {
        return "Введенное число является палиндромом.";
        }
        else
        {
        return "Введенное число не является палиндромом.";
        }
    }    
}

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
string s = GetPalindrom(number);
Console.WriteLine(s);



/*int index = 1;
int a = number;
while (a / 10 > 0)
{
    a = a / 10;
    index++;
}

if (index != 5)
{
    Console.WriteLine("Введенное число не пятизначное.");
}
else
{
    if (number/10000 == number%10 && (number/1000)%10 == (number/10)%10)
    {
        Console.WriteLine("Введенное число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Введенное число не является палиндромом.");
    }
}   */
