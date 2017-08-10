using System;

namespace exercies_1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float weight, height, bmi;
			while (true)
			{
				Console.WriteLine ("Enter height !");
				height = Convert.ToInt64 (Console.ReadLine ());
				height = height / 100; 
				Console.WriteLine ("Enter weight !");
				weight = Convert.ToInt64 (Console.ReadLine());
				bmi = weight / (height*height);

				Console.Write ("BMI is :");
				Console.WriteLine (bmi);

				if (bmi < 16)
				{
					Console.WriteLine ("You're severely underweight");
				} 
				else if (bmi <= 18.5) 
				{
					Console.WriteLine ("You're underweight");
				}
				else if (bmi <= 25) 
				{
					Console.WriteLine ("You're normal");
				}
				else if (bmi <= 30) 
				{
					Console.WriteLine ("You're overweigh");
				}
				else 
				{
					Console.WriteLine ("You're obese");
				}

				Console.WriteLine("");

			}
		}
	}
}
