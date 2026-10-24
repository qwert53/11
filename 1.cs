Console.Write("Ім'я героя: ");
string n = Console.ReadLine()!;
Console.WriteLine("1 - Меч, 2 - Лук, 3 - Посох");
int z = int.Parse(Console.ReadLine()!);
int d = 10;
if (z == 1) d = 20;
if (z == 2) d = 15;
int h = 100;
int m = 100;
while (h > 0 && m > 0)
{
m -= d;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{n} атакує! Манекен: {Math.Max(0, m)} HP");
Console.ResetColor();
if (m <= 0) break;
h -= 10;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Манекен атакує! Герой: {h} HP");
Console.ResetColor();
}
if (m <= 0)
{
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"{n} переміг!");
}
else
{
Console.WriteLine("Герой програв!");
}
Console.ResetColor();