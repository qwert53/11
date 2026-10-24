using System;
class Circle
{
private double r;
public double Radius
{
get { return r; }
set
{
if (value <= 0)
Console.WriteLine("Помилка! Радіус має бути більше 0.");
else
r = value;
}}
public double Area()
{
return Math.PI * r * r;
}
public double P()
{
return 2 * Math.PI * r;
}}
class Program
{
static void Main()
{
Circle c = new Circle();
Console.Write("Введіть радіус: ");
c.Radius = double.Parse(Console.ReadLine()!);
Console.WriteLine("Радіус: " + c.Radius);
Console.WriteLine("Площа: " + c.Area());
Console.WriteLine("Довжина: " + c.P());
}}