using System;
using System.Runtime.InteropServices;
namespace DoWhileLoop;
class Program 
{
    public static void Main(string[] args)
    {
        string opt="";
        do
        {
        Console.Write("Enter a number:");
        int number1=int.Parse(Console.ReadLine());
        if (number1%2 == 0)
        {
            Console.WriteLine("{0} is even",number1);
        }
        else
        {
            Console.WriteLine("{0} is odd",number1);
        }
        Console.WriteLine("Do you want to repeat the process? Yes or No: ");
        opt=Console.ReadLine();
        if(opt == "Yes")
        {

        }
        else if(opt == "No")
        {

        }
        else
        {
            Console.WriteLine("Worng Input Please Enter the Valid Input:");
            opt="Yes";
        }
        }while(opt=="Yes");

    }
}
