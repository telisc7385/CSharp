using System;
namespace ConsoleApplication
{
    public class Program 
{
	void get(ref int y)
	{
	y=10;
	Console.WriteLine(y);
	}
        public static void Main()
        {			int y=20;
			Program p=new Program();
			Console.WriteLine("before function call:-"+y);
			p.get(ref y);
			Console.WriteLine("after function call:-"+y);
            Console.ReadLine();

        }    }}

