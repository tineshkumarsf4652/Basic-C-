using System;
namespace DateAndTime;
class Program 
{
    public static void Main(string[] args)
    {
        DateTime date1=new DateTime(2021,8,10,10,40,32);
        Console.WriteLine($"Year: {date1.Year}");
        Console.WriteLine($"Month: {date1.Month}");
        Console.WriteLine($"Day: {date1.Day}");
        Console.WriteLine($"Hour: {date1.Hour}");
        Console.WriteLine($"Minute: {date1.Minute}");
        Console.WriteLine($"Second: {date1.Second}");
        Console.WriteLine();

        Console.WriteLine("Reverse order:");
        Console.WriteLine(date1.ToString("tt ss mm hh dd MM yyyy"));
        Console.WriteLine();

        DateTime date2;
        Console.WriteLine("Enter the DateTime yyyy/MM/dd hh:mm:ss tt:");
        bool temp=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.AdjustToUniversal,out date2);
        while(!temp)
        {
            Console.WriteLine("Enter Correct formate of DateTime yyyy/MM/dd hh:mm:ss tt:");
            temp=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.AdjustToUniversal,out date2);
        }
        Console.WriteLine($"Year: {date2.Year}");
        Console.WriteLine($"Month: {date2.Month}");
        Console.WriteLine($"Day: {date2.Day}");
    }
}
