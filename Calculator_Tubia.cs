/*
 * Created by SharpDevelop.
 * User: Jaycee
 * Date: 12/17/2019
 * Time: 1:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			double F, S, Res;
			string opt = "";
			
			Console.WriteLine("Please Enter First Number =");
			F = double.Parse(Console.ReadLine());
			Console.WriteLine("Please Enter Second Number=");
			S = double.Parse(Console.ReadLine());
			Console.WriteLine("Select Your Operation:");
			opt = (Console.ReadLine());
			switch (opt)
			{
				case "+":
					{
						Res = F + S;
						Console.WriteLine("Result=" + Res);
						
						break;
					}
				case "-":
					{
						if (F > S)
							Res = F - S;
						else if (S > F)
							Res = S - F;
						else
							Res = F - S;
						Console.WriteLine("Result=" + Res);
						break;
					}
				case "*":
					{
						Res = F * S;
						Console.WriteLine("Result=" + Res);
						break;
					}
				case "/":
					{
						if (F / S == 0)
						{
							Res = F / S;
						
							Console.WriteLine("Result=" + Res);
						}
						else if (F / S != 0)
							Console.WriteLine("Numbers are not fully divided!");
						break;
					}
				default:
					
					Console.WriteLine("You have selected a wrong operator");
					break;
			}	
			
			Console.ReadKey();
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to try a number . . . ");
			Console.ReadKey(true);
		}
	}
}