using System;
namespace IfCondition;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the mark:");
        float mark = int.Parse(Console.ReadLine());
        if ((mark<=100)&&(mark>=0))
        {
            if (mark>=80)
            {
                Console.WriteLine("Grade A");
            }
            else if ((mark>=61)&&(mark<80))
            {
                Console.WriteLine("Grade B");
            }
            else if ((mark>=36)&&(mark<=60))
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Grade D");
            }

        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}
