using System;
class Rectangle
{
public double a;
public double b;
public Rectangle(double x, double y)
{
a = x;
b = y;
}
public double Pl()
{
return a * b;
}
public double P()
{
return 2 * (a + b);
}
public bool Kv()
{
return a == b;
}
public void Show()
{
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("Площа = " + Pl());
Console.WriteLine("Периметр = " + P());
Console.WriteLine("Квадрат = " + (Kv() ? "Так" : "Ні"));
}
}
class Program
{
static void Main()
{
Rectangle[] r = new Rectangle[2];
r[0] = new Rectangle(5, 3);
r[1] = new Rectangle(4, 4);
for (int i = 0; i < r.Length; i++)
{
Console.WriteLine("Прямокутник " + (i + 1));
r[i].Show();
}
}
}