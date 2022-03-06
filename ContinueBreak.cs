using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ContinueBreak
{
		class ContinueBreak
		{
			static void Main(string[] args)
			{
				string signal = "o";
				while(signal != "x"){
					Console.Write("Podaj sygnał: " );
					signal = Console.ReadLine();
					Console.WriteLine(" Sygnal: {0}", signal);
					
					if (signal == "a"){
						Console.WriteLine( "Error! End of the task\n");
						break;
					}
					if (signal == "o"){
						Console.WriteLine( "Accepted!\n");
						continue;
					}
					Console.WriteLine( "{0} -- Alarm!\n", signal);					
				}
					
			}
			
		}	
}