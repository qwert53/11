using System;
class Student
{
string name;
string group;
double bal;
public Student(string n, string g, double b)
{
name=n;
group=g;
bal=b;
}
public void Show()
{
Console.WriteLine("Ім'я: " + name);
Console.WriteLine("Група: " + group);
Console.WriteLine("Середній бал: " + bal);
}
}
class Program
{
static void Main()
{
Student s1=new Student("Юра", "П33", 10.5);
Student s2=new Student("Влад", "П34", 11.5);
s1.Show();
s2.Show();
}
}