using System;
namespace ArrayAssignment;
class Program
{
    public static void Main(string []args)
    {
        // create array of size 5 and add names
        string [] names=new string[5]{"Hari","Ganesh","Venkat","Suresh","Venkat"};
        // print names using for
        for(int i=0;i<names.Length;i++)
        {
            Console.WriteLine(names[i]);
        }
        // get a name from the user to search
        Console.WriteLine("Enter a name to search");
        string name=Console.ReadLine();
        // search using for loop and print index
        int flag=0;
        for(int i=0;i<names.Length;i++)
        {
            if(names[i]==name)
            {
                Console.WriteLine($"The name is present in the array in the index of {i}");
                flag=1;
                // break;
            }
        }
        if(flag==0)
        {
            Console.WriteLine($"The name is not present in the array");
        }
        // search using foreach
        int flag1=0;
        foreach(string i in names)
        {
            if(i==name)
            {
                Console.WriteLine("The name is present in the array");
                flag1=1;
            }
        }
        if(flag1==0)
        {
            Console.WriteLine("The name is not present in the array");
        }
        
    }
}
