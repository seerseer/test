using System;
using System.IO;
using System.Text;
using System.Collections.Generic;



public class Solution
{

	// this also works
	//public static int LCSubStr(int[,] table, string X, string Y)

	public static int LCSubStr(string X, string Y)
	{
		int m = X.Length;
		int n = Y.Length;
		int[,] table = new int[m+1,n+1];
		for(int i=0; i<table.GetLength(0); i++)
		{
			for(int j=0; j<table.GetLength(1); j++)
			{
				Console.Write(table[i,j]);
			}
			Console.WriteLine();
		}
		//List<List<int>> table = new List<List<int>>();
		int result = 0;
		for(int i=0; i<=m; i++)
		{
			for(int j=0; j<=n; j++)
			{
				if(i==0 || j==0)
				{
					table[i,j] = 0;
				}
				else if(X[i-1] == Y[j-1])
				{
					table[i,j] = table[i-1,j-1] + 1;
					result = Math.Max(result, table[i,j]);
				}
				else
				{
					table[i,j] = 0;
				}
			}
		}
		return result;
	}
	
	static void Main()
	{

		string X = "abcdefghijk";
		string Y = "vncvdkabcdefgl";
		Console.WriteLine(LCSubStr(X,Y));

		
		Console.WriteLine("\nthis is a test.");
	}
	
}