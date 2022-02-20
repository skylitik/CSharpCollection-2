using System;
using System.Collections.Generic;
using System.Text;

namespace WhileLoop
{
		class WhileLoop
		{
			static void Main(string[] args)
			{
				int i = 0;
				while(i < 100000)
				{
					Console.WriteLine("Czarek is beautifull kitten: {0} chrupeczek dostanie))Słodkij dziub)*\n", i );
					Console.WriteLine("Lamonia juz Ci daje chrupeczki");
					i++;
				}
				return;
			}
			
		}	
}