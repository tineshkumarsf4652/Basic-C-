using System;
namespace SwitchCase;
class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number1:");
        float number1 = float.Parse(Console.ReadLine());

        Console.Write("Enter number2:");
        float number2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Select an option:");
        char option = char.Parse(Console.ReadLine());

        switch(option)
        {
            case '+':
            {
                float add = number1 + number2;
                Console.WriteLine($"Addition of two numbers:{add}");
                break;
            }
            case '-':
            {
                float sub = number1 - number2;
                Console.WriteLine($"Subraction of two numbers:{sub}");
                break;
            }
            case '*':
            {
                float mul = number1 * number2;
                Console.WriteLine($"Multiplication of two numbers:{mul}");
                break;
            }
            case '/':
            {
                float quo = number1 / number2;
                Console.WriteLine($"Division of two numbers:{quo}");
                break;
            }
            case '%':
            {
                float rem = number1 % number2;
                Console.WriteLine($"Modulo division of two numbers:{rem}");
                break;
            }
            default:
            {
                Console.WriteLine("Operation is Invalid");
                break;
            }
        }
    }
}
