#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace DeclaringConstructor
{
	public class Time
	{
		int Year;
		int Month;
		int Date;
		int Hour;
		int Minute;
		int Second;
		
		public void DisplayCurrentTime()
		{
			Console.WriteLine( "{0}/{1}/{2}/ {3}:{4}:{5}", Date, Month, Year, Hour, Minute, Second);
		}
		
		//Constructor
		public Time(DateTime dt){
			Year = dt.Year;
			Month = dt.Month;
			Date = dt.Day;
			Hour = dt.Hour;
			Minute = dt.Minute;
			Second = dt.Second;
		}
	}
	public class Tester
	{
		static void Main()
		{
			DateTime currentTime = DateTime.Now;
			Time t = new Time(currentTime);
			t.DisplayCurrentTime();
			
		}
	}
}