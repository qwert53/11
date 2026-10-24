using System;
class Person
{
public string Name { get; set; }
public int Age { get; set; }
public Person(string n, int a)
{
Name = n;
Age = a;
}
public void Show()
{
Console.WriteLine("Ім'я: " + Name);
Console.WriteLine("Вік: " + Age);
}
}
class Student : Person
{
public string Faculty { get; set; }
public int Course { get; set; }
public Student(string n, int a, string f, int c) : base(n, a)
{
Faculty = f;
Course = c;
}
public void ShowStudent()
{
Show();
Console.WriteLine("Факультет: " + Faculty);
Console.WriteLine("Курс: " + Course);
}}
class Program
{
static void Main()
{
Person a = new Person("Денис", 18);
Student b = new Student("Влад", 17, "ІПЗ", 3);
a.Show();
b.ShowStudent();
}
}