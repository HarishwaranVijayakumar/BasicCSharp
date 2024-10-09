using System;
namespace ForLoop;
class Program
{
    public static void Main()
    {
        // get 2 integer value from the user
        int start,end,sum=0;
        Console.WriteLine("Enter starting Number");
        start=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the ending number");
        end=int.Parse(Console.ReadLine());
        // calculate the sum of square between 2 integer number
        for(int i=start+1;i<end;i++)
        {
            sum+=(i*i);
        }
        Console.WriteLine(sum);
    }
}