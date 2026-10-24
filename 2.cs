using System;
class Point
{
public double x;
public double y;
public Point(double a, double b)
{
x = a;
y = b;
}
public void Show()
{
Console.WriteLine("X: " + x + " Y: " + y);
}}
class Program
{
static void Main()
{
Point p1 = new Point(2, 3);
Point p2 = new Point(-4, 5);
Point p3 = new Point(-2, -6);
p1.Show();
p2.Show();
p3.Show();
}}