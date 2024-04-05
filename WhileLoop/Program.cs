using System;
namespace WhileLoop;
class Program {
    public static void Main(string[] args)
    {
        //Excercise 1
        int i=0;
        while(i<25)
        {
            if (i%2 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }

        //Exercise 2
        Console.Write("Enter a number: ");
        bool isvalid = int.TryParse(Console.ReadLine(),out int output);
        while(!isvalid)
        {
            Console.Write("Invalid Number. Enter again: ");
            isvalid = int.TryParse(Console.ReadLine(),out output);
        }
    }
}
