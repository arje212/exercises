using System;

namespace Loop
{
	class ForLoop
	{
		public static void Main(string[] args)
		{
			for (int i=0; i<=4; i=i+1)
			{
			    for (int y=0; y<=i; y++)
			    {
			        Console.Write("*");
			    }
				Console.WriteLine("");
			}
		}
	}	
}
