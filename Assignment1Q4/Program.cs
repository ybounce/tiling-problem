/*COIS 4050H Assignment 1 Q4 Part A
 * Seyedyashar Morabbiheravi
 * Student ID 0547952
 * Major Element Problem
 *Find the Major Element in the array
 * -1 is assign to NULL
 * 
 **/




using System;

namespace Assignment1Q4
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Create a Array
			int[] grid = new int[19] { 1,2,1,2,1,2,2,2,1,3,2,3,4,3,2,3,2,2,2};


			// Print the array
			for (int j=0; j < grid.Length; j++)
			{
				Console.Write(grid[j]);
			}

			Console.WriteLine();


			// Slice the Grid 
			int[] major = slice(grid, 0, 18);

			// Check for the Major Element
			//Testing 

			/*for (int i = 0; i < major.Length; i++)
			{

				Console.Write(major[i]);
			}*/
			if (finalCheck(grid, major[0]) == 1)
			{
				Console.Write("The Major Element is {0}", major[0]);

			}
			else if (finalCheck(grid, major[1]) == 1)
			{
				Console.Write("The Major Elemet  is {0}", major[1]);
			}
			else {
				Console.Write("NO Major Element");
			}



		}

		// Final Check 
		public static int finalCheck (int[] grid, int x)
		{
			int countt = 0;
			for (int i=0; i < grid.Length; i++)
			{
				if (grid[i] == x)
				{ countt++; }

			}


			if (countt >= Math.Ceiling(Convert.ToDouble(
				grid.Length / 2))){
				return 1;
			}
			else
				return 0;


		}



	




		public static int[] slice(int[] grid, int start, double end)
		{
			int instart = start;
			int count = 0; 
			while (start <= end)
			{
				if (start < end)
				{

					if (grid[start] == grid[start + 1])
					{
						grid[count] = grid[start];
						Console.Write(grid[count]);


					}
					else if (grid[start] == -1)
					{
						grid[count] = grid[start + 1];
						Console.Write(grid[count]);


					}
					else if (grid[start + 1] == -1)
					{
						grid[count] = grid[start];
						Console.Write(grid[count]);
					}

					else
					{
						// -1 is the null
						grid[count] = -1;
						Console.Write(grid[count]);
					}

				}
				else {
					
					grid[count] = grid[start];
					Console.Write(grid[count]);
				}
				start = start + 2;
				count++;

			}
			if (instart + 2 == Convert.ToInt32( end))
			{
				// TESTING 
				//Console.Write(grid[0]);
				//Console.Write(grid[1]);
				Console.WriteLine();

				
				return grid;
			}
			else
			{
				Console.WriteLine();
				Console.WriteLine("_______________________"); 
				return slice(grid, instart, Math.Ceiling(end / 2));

			}

		
		
		}
	}



}
