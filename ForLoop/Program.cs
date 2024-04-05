using System;
using System.Diagnostics.CodeAnalysis;
namespace ForLoop;
class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter initial value:");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter limit value:");
        int number2 = int.Parse(Console.ReadLine());
        int sum=0;
        for(int i=number1; i<=number2; i++)
        {
           int sq = i * i;
           sum+=sq;
        }
        Console.WriteLine("Sum of square of the numbers between the {0} and {1}: {2} ",number1,number2,sum);
    }
}