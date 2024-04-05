using System;
namespace String;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Main String:");
        string mainstring=Console.ReadLine();
        Console.WriteLine("String to be searched:");
        string search=Console.ReadLine();
        int size=search.Length;
        int count=0;
        for(int i=0; i<mainstring.Length-size+1; i++)
        {
            string substring=mainstring.Substring(i,size);
            if(substring==search)
            {
                count+=1;
            }
        }
        Console.WriteLine("Count: {0}",count);
    }
}
