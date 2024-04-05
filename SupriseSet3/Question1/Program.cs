using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        int size=int.Parse(Console.ReadLine());
        string str=Console.ReadLine();
        string[] str1=str.Split(" ");
        string str2="";
        int[] arr1=new int[size];
        for(int i=0; i<size; i++)
        {
            arr1[i]=int.Parse(str1[i]);
        }
        for(int i=0; i<size-1; i++)
        {
            if(arr1[i]<arr1[i+1])
            {
                str2+=arr1[i+1]+" ";
            }
            else if(arr1[i]>arr1[i+1])
            {
               str2+=arr1[i]+" ";
            }
            else
            {
                str2+=arr1[i]+" ";
            }
        }
        Console.WriteLine(str2.TrimEnd());
    }
}
