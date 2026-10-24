using System;
class Point
{
public double x;
public double y;
public Point()
{
x = 0;
y = 0;
}
public Point(double a, double b)
{
x = a;
y = b;
}
public void Show()
{
Console.WriteLine("x = " + x + ", y = " + y);
}}
class Program
{
static void Main()
{
Point p1 = new Point();
Point p2 = new Point(3, 5);
p1.Show();
p2.Show();
}}