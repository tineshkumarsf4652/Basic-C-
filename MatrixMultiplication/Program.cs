using System;
namespace Practice;
class Program 
{
    public static void Main(string[] args)
    {
            int[] arr=new int[12];
            for(int i=0; i<12; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            int[,] arr1=new int[2,3];
            int[,] arr2=new int[3,2];
            int[,] arr3=new int[2,2];
            int index1=0;
            int index2=0;
            for(int i=0; i<2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    arr1[i,j]=arr[index1++];
                }
            }
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<2; j++)
                {
                    arr2[i,j]=arr[index2++];
                }
            }
           for(int i=0; i<2; i++)
           {
                for(int j=0; j<3; j++)
                {
                    arr3[i,j]=arr1[i,j]*arr2[j,i];
                }
           }
           for(int i=0; i<2; i++)
           {
                for(int j=0; j<2; j++)
                {
                    Console.Write(arr3[i,j]);
                }
                Console.WriteLine();
           }
        }
    }