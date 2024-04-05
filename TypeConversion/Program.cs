using System;
using System.Xml.Schema;
namespace TypeConversion;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        Console.Write("Enter age:");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject1:");
        float subject1 = float.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject2:");
        float subject2 = float.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject3:");
        float subject3 = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter Grade:");
        string grade = Console.ReadLine();

        Console.WriteLine("Enter Mobile number:");
        long mobile = long.Parse( Console.ReadLine());

        Console.WriteLine("Enter Mail Id:");
        string email = Console.ReadLine();

        float total = subject1 + subject2 + subject3;

        float average = total/3;

        Console.WriteLine("Trainee Details are:");
        Console.WriteLine($"Name:{name}");
        Console.WriteLine($"Age:{age}");
        Console.WriteLine($"Mobile:{mobile}");
        Console.WriteLine($"Marks1:{subject1}");
        Console.WriteLine($"Marks2:{subject2}");
        Console.WriteLine($"Marks3:{subject3}");
        Console.WriteLine($"Total:{total}");
        Console.WriteLine($"Average:{average}");
        Console.WriteLine($"Grade:{grade}");
        Console.WriteLine($"Mail id:{email}");
    }
}