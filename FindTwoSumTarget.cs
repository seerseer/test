using System;
using System.IO;
using System.Text;
using System.Collections.Generic;



public class Solution
{
	
	static int[] FindTwoSumTarget(int[] numbers, int target)
	{
		int[] res = new int[2];
		int len = numbers.Length;
		if(len < 2) 
		{
			res[0] = -1;
			res[1] = -1;
			return res;
		}
		Dictionary<int, int> dict = new Dictionary<int,int>();
		for(int i=0; i<len; i++){
			if( dict.ContainsKey(target-numbers[i]) )
			{
				res[0] = dict[target-numbers[i]];
				res[1] = i;
			}
			else
			{
				dict[numbers[i]] = i;	
				//dict.Add(numbers[i],i);
			}
		}
		return res;		
	}
	
	static void Main()
	{
		int[] numbers = {2,7,11,15};
		int[] res = FindTwoSumTarget(numbers, 9);
		foreach(int v in res){
			Console.WriteLine(v);
		}

		Console.WriteLine("\nthis is a test.");
		
	}
	
}