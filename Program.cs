/*
 * Created by SharpDevelop.
 * User: Zoltran32
 * Date: 25.06.2020
 * Time: 19:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Array_basics
{	
	class Program
	{
		public static void userInfo()
		{
			Console.WriteLine("Type command for action with array of int, that has some elements");
			Console.WriteLine("1 - for counting summ of integers in array");
			Console.WriteLine("2 - for finding maximum element in array");
			Console.WriteLine("3 - for finding minimus element in array");
			Console.WriteLine("0 - to end work with array");
		}
	
		public static void Main(string[] args)
		{
			bool canWork = true;
			
			Console.WriteLine("Type length for array");
			int size = Convert.ToInt32(Console.ReadLine());
			int[] numbers = new int[size];
			for(int i = 0; i < size; i++)
			{
				Console.WriteLine("Type {0} element of array", i+1);
				numbers[i] = Convert.ToInt32(Console.ReadLine());
			}
			
			while(!canWork) 
			{
				//Used so many actions may be performed with array
				//Not implemented any functionality yet				
			}
			userInfo();
			Console.WriteLine("Press any key to exit");
			Console.ReadKey();
		}		
	}
}