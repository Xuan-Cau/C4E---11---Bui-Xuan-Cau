using System;

namespace exercies_3
{
	class MainClass
	{
		public static void Main (string[] args)
		{	
			while (true) 
			{	
				int columns, rows;
				Console.Write ("what colums: ");
				columns = Convert.ToInt32 (Console.ReadLine ()); 

				Console.Write ("what rows: ");
				rows = Convert.ToInt32 (Console.ReadLine ());

				for (int i = 0; i < rows; i++)
				{
					for (int j = 0; j < columns; j++) 
					{
						if (i % 2 == 0) 
						{
							Console.Write ("x*");
						} 
						else 
						{
							Console.Write ("*x");
						}
					}
					Console.WriteLine ("");
				}
				Console.WriteLine (" ");
			}
		}
	}
}
