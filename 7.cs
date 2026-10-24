using System;
class Student
{
public string n;
public string g;
public static int k = 0;
public Student(string a, string b)
{
n = a;
g = b;
k++;
}
public void Show()
{
Console.WriteLine("Ім'я: " + n);
Console.WriteLine("Група: " + g);
}}
class Program
{
static void Main()
{
Student s1 = new Student("Юра", "П33");
Student s2 = new Student("Влад", "П34");
Student s3 = new Student("Денис", "П33");
s1.Show();
s2.Show();
s3.Show();
Console.WriteLine("Кількість студентів: " + Student.k);
}}