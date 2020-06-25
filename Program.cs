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
			//Doesn't look as good design because adding new commands can be complicated
			//Also, there is a text typing format for console output
			Console.WriteLine("Type command for action with array of int, that has some elements");
			Console.WriteLine("1 - for counting summ of integers in array");
			Console.WriteLine("2 - for finding maximum element in array");
			Console.WriteLine("3 - for finding minimus element in array");
			Console.WriteLine("0 - to end work with array");
		}
	
		public static void Main(string[] args)
		{
			Console.WriteLine("Type integer number for length of array of integers");
			//Problem, user can type invalid input that will crash application
			int size = Convert.ToInt32(Console.ReadLine());
			int[] numbers = new int[size];
			for(int i = 0; i < size; i++)
			{
				Console.WriteLine("Type element numbers[{0}] of array", i+1);
				//Problem, user can type invalid input that will crash application				
				numbers[i] = Convert.ToInt32(Console.ReadLine());
			}
			
			int command = -1;
			while(command != 0) 
			{	
				//Input filtration cycle (not implemented yet)				
				while(command < 0 || command > 3) //Warning, magic numbers detected
				{
					userInfo();
					//Problem, user can type invalid input that will crash application
					command = Convert.ToInt32(Console.ReadLine());
				}
				
				switch(command)
				{
					case 1:
						//Do something
						break;
					case 2:
						//Do another thing
						break;
					case 3:
						//Do third thing
						break;
					default:
						//Exit program. Command is 0 due to input filtration (not implemented yet)
						break;
				}
			}
			Console.WriteLine("Press any key to exit");
			Console.ReadKey();
		}		
	}
}