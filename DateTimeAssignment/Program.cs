using System;
using System.Diagnostics;
namespace DataTimeAssignment;
class Program
{
    public static void Main(string []args)
    {
        // create aa datetime object
        DateTime date1=new DateTime(2021,8,10,10,40,32);
        Console.WriteLine(date1);
        // display the date time individually
        Console.WriteLine(date1.Year);
        Console.WriteLine(date1.Month);
        Console.WriteLine(date1.Day);
        Console.WriteLine(date1.Hour);
        Console.WriteLine(date1.Minute);
        Console.WriteLine(date1.Second);
        // convert to string
        string date=date1.ToString("yyyy/M/dd/hh/mm/ss/tt");
        Console.WriteLine(date);
        string []dateArray=date.Split('/');
        // split that string and print in reverse order

        for(int i=dateArray.Length-1;i>=0;i--)
        {
            Console.Write(dateArray[i]+" ");
        }
        Console.WriteLine();
        // get date time object from the user yyyy/MM/dd hh:mm:ss tt
        DateTime date2;
        bool dateOne=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out date2);
        while(!dateOne)
        {
            dateOne=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out date2);   
        }
        Console.WriteLine(date2.Year);
        Console.WriteLine(date2.Month);
        Console.WriteLine(date2.Day);
    }
}