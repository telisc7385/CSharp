using System;
namespace CSharp_Shell
{    public class Program 
	{
	void add(int a,int b)
	{
	int c=a+b;
	Console.WriteLine("Addition of a and b="+c);
	}
	void add(int a,int b,int c)
	{
	int c1= a+b+c;
	Console.WriteLine("Addition of a.b and c="+c1);
	}
        public static void Main(string [] args)
        {			Program p=new Program();
			p.add(11,20);
			p.add(14,20,10);
			Console.ReadLine();
        }    }}
