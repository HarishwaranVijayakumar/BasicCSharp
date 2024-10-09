using System;
namespace MethodsAssignment;
class Program()
{
    public static void Main(string []args)
    {   string repeat="";
        do{
        Console.WriteLine("Enter the number");
        double number1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the number");
        double number2=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Choose the option from the below\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
        int option=Convert.ToInt32(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                Console.WriteLine($"The result is : {Addition(number1,number2)}");
                break;
            }
            case 2:
            {
                Console.WriteLine($"The result is : {Subtraction(number1,number2)}");
                break;
            }
            case 3:
            {
                Console.WriteLine($"The result is : {Multiplication(number1,number2)}");
                break;
            }
            case 4:
            {
                Console.WriteLine($"The result is : {Division(number1,number2)}");
                break;
            }
            default:
            {
                Console.WriteLine("Invalid option");
                break;
            }
        }
        Console.WriteLine("Do you want to continue?");
        repeat=Console.ReadLine();

    }while(repeat=="yes");
        // ask to numbers to do mathematical operation
        // display the menu and ask the user for the input
        // use do while for repeatation of the operation 

    }
    static double Addition(double number1,double number2)
    {
        return number1+number2;
    }
    static double Subtraction(double number1,double number2)
    {
        return number1-number2;
    }
    static double Multiplication(double number1, double number2)
    {
        return number1*number2;
    }
    static double Division(double number1, double number2)
    {
        return number1/number2;
    }
}