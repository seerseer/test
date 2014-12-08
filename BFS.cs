using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

public class Node
{
	public int val;
	public Node left;
	public Node right;
	public Node(int val){
		this.val = val;
		left = null;
		right = null;
	}
}

public class Solution
{
	
	public static List<int> BreadthFirstSearch(Node root)
	{
		List<int> list = new List<int>();
		if(root == null)
		{
			return list;
		}
		Queue<Node> mq = new Queue<Node>();
		mq.Enqueue(root);
		while(mq.Count > 0)
		{
			Node node = mq.Dequeue();
			list.Add(node.val);
			if(node.left != null)
			{
				mq.Enqueue(node.left);
			}
			if(node.right != null)
			{
				mq.Enqueue(node.right);
			}
		}
		return list;		
	}
	
	public static void LevelBFS(Node root)
	{
		if(root == null)
		{
			return ;
		}
		
		Queue<Node> mq = new Queue<Node>();
		mq.Enqueue(root);
		
		while(mq.Count > 0)
		{
			int size = mq.Count;
			for(int i=0; i<size; i++)
			{
				Node node = mq.Dequeue();
				Console.Write(" {0} ",node.val);
				if(node.left != null)
				{
					mq.Enqueue(node.left);
				}
				if(node.right != null)
				{
					mq.Enqueue(node.right);
				}
			}
			Console.Write("\n");
		}
	}
	
	static void Main()
	{
		Node node1 = new Node(8);
		Node node2 = new Node(4);
		Node node3 = new Node(2);
		Node node4 = new Node(6);
		Node node5 = new Node(12);
		Node node6 = new Node(10);
		Node node7 = new Node(14);
		Node node8 = new Node(1);
		Node node9 = new Node(3);
		
		node1.left = node2;
		node1.right = node5;
		node2.left = node3;
		node2.right = node4;
		node3.left = node8;
		node3.right = node9;
		node5.left = node6;
		node5.right = node7;
		
		List<int> list = BreadthFirstSearch(node1);
		foreach(int v in list)
		{
			Console.WriteLine(v);
		}
		
		Console.WriteLine("this is a test.");

		
		LevelBFS(node1);
		
		Console.WriteLine("this is a test.");
		
	}
	
}