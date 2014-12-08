using System;
using System.IO;
using System.Text;
using System.Collections.Generic;



public class Solution
{
	
	public static bool ValidParenthese(string s)
	{
		if(s == null)
		{
			return false;
		}
		if(s.Length == 0)
		{
			return true;
		}
		Stack<char> st = new Stack<char>();
		string pattern = "([{";
		int i = 0;
		for(i=0; i<s.Length; i++)
		{
			int pos = pattern.IndexOf(s[i]);
			if(pos >= 0)
			{
				st.Push(s[i]);
			}
			else
			{
				if(st.Count > 0 && CompareBracket(st.Peek(), s[i]) == true)
				{
					st.Pop();
				}else{
					return false;
				}
			}
		}
		if(st.Count == 0 && i == s.Length)
		{
			return true;
		}
		return false;
	}
	
	public static bool CompareBracket(char left, char right)
	{
		if( (left == '(' && right == ')') || (left == '[' && right == ']') || (left == '{' && right == '}') )
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	
	static void Main()
	{
		string s = "{[()][()]()[]})";
		Console.WriteLine(ValidParenthese(s));
		Console.WriteLine("this is a test.");
		
	}
	
}