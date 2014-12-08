using System;
using System.IO;
using System.Text;
using System.Collections.Generic;



public class Solution
{
	
	static void Main()
	{
		string str = " this is a test ";
		string[] strs = str.Split(' ');
		Console.WriteLine(strs.Length);
		foreach(string v in strs)
		{
			if(v.Trim() != "")
			{
				Console.WriteLine(v);
			}
		}
		string str2 = "test";
		foreach(char v in str2)
		{
			char c = v + 26;
			Console.Write(c);
		}
		Console.WriteLine("this is a test.");
		
	}
	
}