using System;
namespace WhileLoop;
class Program
{
    public static void Main(string []args)
    {
        // Exercise 1
        int initial=0;
        // check condition
        while(initial<=25)
        {
            // check if even or not
            if(initial%2==0)
            {
                Console.WriteLine(initial);
            }
            // loop break
            initial++;
        }

        // exercise 2
        // get a valid number from user
        int number;
        bool valid=int.TryParse(Console.ReadLine(),out number);
        // if the input is valid break the loop and print the number
        // if the input is invalid ask the user to enter the correct format
        while(!valid)
        {
            Console.WriteLine("Invalid format.Please enter the input in number format.");
            valid=int.TryParse(Console.ReadLine(),out number);
        }
        Console.WriteLine(number);      
    }
}
