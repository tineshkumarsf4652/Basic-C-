using System;
namespace AgeCalculate;
class Program 
{
    public static void Main(string[] args)
    {
        DateTime date1,date2;
        Console.WriteLine("Enter the Date of Birth:");
        bool istrue1=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.AdjustToUniversal,out date1);
        bool istrue2=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.AdjustToUniversal,out date2);
        TimeSpan date3=date1-date2;
        int age=date3.Days/365;
        Console.WriteLine(date3.Days);
        string s=date1.DayOfWeek.ToString();
        Console.WriteLine(age);
        Console.WriteLine(s);
        Console.WriteLine(date3.TotalHours);
        Console.WriteLine(date3.TotalMinutes);
        }
    }
