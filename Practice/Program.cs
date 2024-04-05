using System;
namespace Practice;
class Program 
{
     public static void Main(string[] args)
     {
          string str1=Console.ReadLine();
          string[] str4=str1.Split();
          string str2=Console.ReadLine();
          string str3=Console.ReadLine();
          string str5="";
          for(int i=str4.Length-1; i>=0; i--)
          {
               str5+=str4[i]+" ";
               if(str4[i]==str3[])
               {
                   str5+=str2+" ";
               }
          }
          string[] str6=str5.Split();
          string str7="";
          string str8="";
          for(int i=str6.Length-1; i>=0; i--)
          {
               str7+=str6[i]+" ";
          }
          str8+=str7.TrimEnd();
          Console.WriteLine(str8.TrimStart());
     }
}


