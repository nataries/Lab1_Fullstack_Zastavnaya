using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Text;

while (true)
{
    Console.WriteLine("Введите своё имя: ");
    string? name = Console.ReadLine();
    Console.WriteLine($"Привет, {name}!");
    Console.WriteLine($"День недели: {DateTime.Now.DayOfWeek}");
    Console.WriteLine("Хотите продолжить (y/n)?");
    string answer = Console.ReadLine();
    if (answer.ToLower() != "y")
    {
        break;
    }
}
