using System;
class Point
{
public double X { get; set; }
public double Y { get; set; }
public Point(double X, double Y)
{
this.X = X;
this.Y = Y;
}
public static Point operator +(Point a, Point b)
{
return new Point(a.X + b.X, a.Y + b.Y);
}
public static bool operator ==(Point a, Point b)
{
if (ReferenceEquals(a, b))
return true;
if (a is null || b is null)
return false;
return a.X == b.X && a.Y == b.Y;
}
public static bool operator !=(Point a, Point b)
{
return !(a == b);
}
public static Point operator *(Point a, double b)
{
return new Point(a.X * b, a.Y * b);
}
public override bool Equals(object a)
{
return a is Point b && this == b;
}
public override int GetHashCode()
{
return HashCode.Combine(X, Y);
}
public override string ToString()
{
return $"({X}, {Y})";
}}
class Program
{
static void Main()
{
Point a = new Point(2, 3);
Point b = new Point(4, 5);
Point c = a + b;
Console.WriteLine("Точка a: " + a);
Console.WriteLine("Точка b: " + b);
Console.WriteLine("a + b = " + c);
Console.WriteLine("a == b: " + (a == b));
Point d = new Point(2, 3);
Console.WriteLine("a == d: " + (a == d));
Console.WriteLine("a != b: " + (a != b));
Console.WriteLine("a != d: " + (a != d));
Point e = a * 5;
Console.WriteLine("a * 5 = " + e);
}}