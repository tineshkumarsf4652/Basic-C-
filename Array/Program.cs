using System;
using System.Threading;
namespace Array;
class Program 
{
    public static void Main(String[] args)
    {
        string[] array1=new string[5]{"Mani","Ganesh", "Venkat", "Suresh", "Venkat"};
        Console.WriteLine("Names:");
        for (int i=0; i<array1.Length; i++)
        {
            Console.WriteLine(array1[i]);
        }
        Console.WriteLine("Enter the name:");
        string name1 = (Console.ReadLine());
        bool flag = false;
        int index =0;
        for(int i=0; i<array1.Length; i++)
        {

           if (name1==array1[i])
            {
              flag=true;
              index=i;
            }
        }
        if(flag)
        {
            Console.WriteLine("The name is present in the array.");
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("The name is not present in the array.");
        }
    }
}
