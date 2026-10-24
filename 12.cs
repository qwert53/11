using System;
class Vehicle
{
protected double Speed;
public Vehicle(double s)
{
Speed = s;
}
public void Start()
{
Console.WriteLine("Транспорт почав рух зі швидкістю " + Speed);
}
}
class Car : Vehicle
{
public Car(double s) : base(s)
{
}
public new void Start()
{
Console.WriteLine("Автомобіль почав рух зі швидкістю " + Speed);
}
}
class Program
{
static void Main()
{
Car a = new Car(60);
a.Start();
}
}