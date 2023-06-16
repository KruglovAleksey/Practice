/* Напишите программу, которая принимает 
на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double GetRass (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double l = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return l;
}

Console.Write("X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Z2: ");
int z2 = int.Parse(Console.ReadLine());

double d = GetRass(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(d,2, MidpointRounding.ToZero));



/*double l = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine(Math.Round(l,2, MidpointRounding.ToZero));*/