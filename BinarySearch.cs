using System;
using System.IO;
using System.Text;
using System.Collections.Generic;



public class Solution
{
	public static int BinarySearch(int[] numbers, int target)
	{
		if(numbers == null || numbers.Length == 0)
		{
			return -1;
		}
		Array.Sort(numbers);
		foreach(int v in numbers)
		{
			Console.WriteLine(v);	
		}
		int start = 0;
		int end = numbers.Length - 1;
		while(start + 1 < end){
			int mid = start + (end - start) / 2;
			if(numbers[mid] > target)
			{
				end = mid;
			}
			else if(numbers[mid] < target)
			{
				start = mid;
			}
			else
			{
				return mid;
			}
		}
		if(numbers[start] == target)
		{
			return start;
		}
		if(numbers[end] == target)
		{
			return end;
		}
		return -1;
	}
	
	
	
	static void Main()
	{
		int[] numbers = {2,7,11,15,5,8,9,20};
		int index = BinarySearch(numbers, 9);
		if(index >= 0)
		{
			Console.WriteLine("{0}, value is {1}",index, numbers[index]);
		}

		Console.WriteLine("\nthis is a test.");
		
	}
	
}