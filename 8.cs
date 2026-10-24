using System;
class R
{
public double a, b;
public double S()
{
return a * b;
}}
class P
{
static void Main()
{
R[] r = new R[5];
for (int i = 0; i < 5; i++)
{
r[i] = new R();
Console.WriteLine("Прямокутник " + (i + 1));
Console.Write("Ширина: ");
r[i].a = Convert.ToDouble(Console.ReadLine());
Console.Write("Висота: ");
r[i].b = Convert.ToDouble(Console.ReadLine());
}
int m = 0;
for (int i = 1; i < 5; i++)
{
if (r[i].S() > r[m].S())
{
m = i;
}}
Console.WriteLine("Найбільша площа: " + r[m].S());
Console.WriteLine("Ширина: " + r[m].a);
Console.WriteLine("Висота: " + r[m].b);
}}