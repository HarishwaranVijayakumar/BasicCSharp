using System;
namespace IfStatement;
class Program{
    public static void Main(string []args){
        // get marks
        Console.WriteLine("Enter mark");
        int mark=Convert.ToInt32(Console.ReadLine());
        // if marks>80 grade A
        if(mark>80 && mark<=100){
            Console.WriteLine("Grade A");
        }
        // else if marks 61-80 grade B
        else if(mark>=61 && mark<=80)
        {
            Console.WriteLine("Grade B");
        }
        // else if marks 36-60 grade C
        else if(mark>=36 && mark<=60)
        {
            Console.WriteLine("Grade C");
        }
        // else if marks<36 grade D
        else if(mark<36 && mark>=0)
        {
            Console.WriteLine("Grade D");
        }
        // else invalid data
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}
