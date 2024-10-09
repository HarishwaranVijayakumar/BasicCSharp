using System;
namespace DoWhileLoop;
class Program
{
    public static void Main(string []args)
    {
        // get the number and check odd or even
        int number;
        string option="yes";
        do{
            if(option=="yes")
            {
                Console.WriteLine("Enter the number");
                number=Convert.ToInt32(Console.ReadLine());
                if(number%2==0)
                { 
                    Console.WriteLine("The number is even");
                }
                else
                {
                    Console.WriteLine("The number is odd");
                }
                Console.WriteLine("Do you want the process to repeat");
                option=Console.ReadLine();
            }
            else if(option!="yes" || option!="no")
            {
                Console.WriteLine("The provided input is wrong and enter the correct input.");
                Console.WriteLine("Do you want the process to repeat");
                option=Console.ReadLine();
            }
            // ask the user to repeat the process 
            
        }while (option!="no");
    }
}
