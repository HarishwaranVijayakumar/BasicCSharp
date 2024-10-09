using System;
namespace SwitchStatement;
class Program{
    public static void Main(string []args)
    {
        // get two integer/double input values from the user
        Console.WriteLine("Enter Number1:");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Number2:");
        double number2=Convert.ToDouble(Console.ReadLine());
        // get the operation from the user
        char operation;
        Console.WriteLine("Enter operations like +, -, *, /, % ");
        operation=Convert.ToChar(Console.ReadLine());
        double result;
        switch(operation)
        {
            // if operation +->add and print result
            case '+':
            {
                result=number1+number2;
                Console.WriteLine(result);
                break;
            }
            // if - ->subtract and print result
            case '-':
            {
                result=number1-number2;
                Console.WriteLine(result);
                break;
            }
            // if * ->multiply and print result
            case '*':
            {
                result=number1*number2;
                Console.WriteLine(result);
                break;
            }  
            // if /->division and print result
            case '/':
            {
                result=number1/number2;
                Console.WriteLine(result);
                break;
            }         
            // if %-> modulous and print result
            case '%':
            {
                result=number1%number2;
                Console.WriteLine(result);
                break;
            }
            // else print invalid operation
            default:
            {
                Console.WriteLine("The operation is invalid");
                break;
            }
        }
    }
}
