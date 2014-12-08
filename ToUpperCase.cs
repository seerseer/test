using System;
using System.IO;
using System.Text;
using System.Collections.Generic;



public class Solution
{
	
	static void Main()
	{
		string str2 = "test";
		foreach(char v in str2)
		{
			char c = (char)(v - 'a' + 'A');
			Console.Write(c);
		}
		
		Console.WriteLine("\n");

		string str3 = str2.ToUpper();
		Console.WriteLine(str3);
		
		char cc = 't';
		cc = char.ToUpper(cc);
		Console.WriteLine(cc);
		
		
		Console.WriteLine("\nthis is a test.");
		
	}
	
}