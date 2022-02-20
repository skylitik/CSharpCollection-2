using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ForLoop
{
		class ForLoop
		{
			static void Main(string[] args)
			{
				for (int i = 0; i <= 100;i++)
				{
					Console.Write("{0} ", i );
					Thread.Sleep(70);
					
					if (i % 10 == 0)
					{
						Console.WriteLine("\t{0}", i );
						
					}
				}
				
				return;
			}
			
		}	
}