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
		public static int ReadInt()
		{
			int result = 0;
			while(int.TryParse(Console.ReadLine(), out result) == false)
			{
				Console.WriteLine("That is not a number");
			}
			return result;
		}
		
		public static void userInfo()	
		{
			//Doesn't look as good design because adding new commands can be complicated
			//Also, there is a text typing format for console output
			Console.WriteLine("Type integer number for command");
			Console.WriteLine("Command make action with array of int, that has some elements");
			Console.WriteLine("Possible actions are this");
			Console.WriteLine("1 - for counting summ of integers in array");
			Console.WriteLine("2 - for finding maximum element in array");
			Console.WriteLine("3 - for finding minimum element in array");
			Console.WriteLine("4 - for printing on console all elements in array");
			Console.WriteLine("0 - to end work with array");
			Console.WriteLine("Any other numbers are skipped");
		}
		
		public static void GetSumm(int[] data)
		{
			int summ = 0;
			for(int i = 0; i < data.Length; i++)
			{
				summ += data[i];
			}
			Console.WriteLine(summ);
		}
		
		public static void GetMax(int[] data) 
		{
			int maximum = Int32.MinValue;
			for(int i = 0; i < data.Length; i++)
			{
				if(data[i] > maximum) 
				{
					maximum = data[i];
				}
			}
			Console.WriteLine(maximum);
		}
		
		public static void GetMin(int[] data)
		{
			int minimum = Int32.MaxValue;
			for(int i = 0; i < data.Length; i++)
			{
				if(data[i] < minimum)
				{
					minimum = data[i];
				}
			}
			Console.WriteLine(minimum);
		}
		
		public static void Print(int[] data)
		{
			for(int i = 0; i < data.Length; i++)
			{
				Console.WriteLine(data[i]);
			}
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Type positive integer number for length of array of integers");
			int size = -1;
			while(size <= 0)
			{
				size = ReadInt();
				if(size <= 0)
				{
					Console.WriteLine("Array size can only be positive");
				}					
			}
			
			int[] numbers = new int[size];
			for(int i = 0; i < size; i++)
			{
				Console.WriteLine("Type element numbers[{0}] of array", i+1);				
				numbers[i] = ReadInt();
			}
			
			int command = -1;
			while(command != 0) 
			{	
				userInfo();
				command = ReadInt();

				switch(command)
				{
					case 1:
						GetSumm(numbers);
						break;
					case 2:
						GetMax(numbers);
						break;
					case 3:
						GetMin(numbers);
						break;
					case 4:
						Print(numbers);
						break;
					default:
						break;
				}
			}
			Console.WriteLine("Press any key to exit");
			Console.ReadKey();
		}		
	}
}