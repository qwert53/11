using System;
class Circle
{
public double r;
public Circle(double a)
{
r = a;
}
public double GetArea()
{
return Math.PI * r * r;
}
public double GetCircumference()
{
return 2 * Math.PI * r;
}
}
class Program
{
static void Main()
{
Console.Write("Введіть радіус кола: ");
double r = double.Parse(Console.ReadLine()!);
Circle c = new Circle(r);
Console.WriteLine("Площа: " + c.GetArea());
Console.WriteLine("Довжина кола: " + c.GetCircumference());
}
}