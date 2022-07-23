using System;
using System.Collections.Generic;
using System.Text;

namespace StaticFields
{
	public class Cat
	{
		private static int instances = 0;
		
		public Cat()
		{
			instances++;
		}
		public static void HowManyCats()
		{
			Console.WriteLine( "Adoptowane koty: {0}", instances);
		}
	}
	
	public class Tester
	{
		static void Main()
		{
			Cat.HowManyCats();
			Cat pupsik = new Cat();
			Cat.HowManyCats();
			Cat fiskars = new Cat();
			Cat.HowManyCats();	
		}	
	}	
}