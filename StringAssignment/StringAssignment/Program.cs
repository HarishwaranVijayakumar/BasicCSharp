using System;
namespace StringAssignment;
class Program
{
    public static void Main()
    {
        // get string from the user 
        Console.WriteLine("Enter long text");
        string text=Console.ReadLine();
        // get substring from the user
        Console.WriteLine("Enter substring to search");
        string sub=Console.ReadLine();
        // search the occurence of the substring
        string [] splitArray=text.Split(sub);
        foreach(string i in splitArray)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(splitArray.Length-1);

    }
}