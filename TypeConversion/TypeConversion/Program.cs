using System;
namespace TypeConversion;
class Program{
    public static void Main(string []args){
        Console.WriteLine("Enter your Name:");
        string name=Console.ReadLine();
        Console.WriteLine("Enter age:");
        int age=Convert.ToInt32(Console.ReadLine());
        int mark1,mark2,mark3;
        Console.WriteLine("Enter mark of subject1:");
        mark1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter mark of subject2:");
        mark2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter mark of subject2:");
        mark3=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter grade");
        string grade=Console.ReadLine();
        Console.WriteLine("Enter mobile number:");
        long mobileNumber=Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Enter mail id:");
        string mailId=Console.ReadLine();
        int total=mark1+mark2+mark3;
        double average=(double)total/3;
        Console.WriteLine($"Trainee Details are\nName:{name}\nAge:{age}\nMobile:{mobileNumber}\nMarks1:{mark1}\nMarks2:{mark2}\nMarks3:{mark3}\nTotal:{total}\nAverage:{average}\nGrade:{grade}\nMail id:{mailId}");





    }
}
