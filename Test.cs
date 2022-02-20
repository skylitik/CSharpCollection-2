using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchStatement
{
	
	class SwitchStatement
	{
		static void Main(string[] args)
		{
						
			const int Democrat = 0;
			const int LiberalRepublican = 1;
			const int Republican = 2;
			const int Libertarian = 3;
			const int NewLeft = 4;
			const int Progressive = 5;
			
			int myChoice = LiberalRepublican;
			
			switch (myChoice)
			{
				case Democrat:
				Console.WriteLine("Oddałaś/eś głos na Demokratów.\n" );
				break;
				case LiberalRepublican:
				Console.WriteLine("Liberalni republikanie głosują na Republikanów.\n" );
				goto case Republican;
				case Republican:
				Console.WriteLine("Oddałaś/eś głos na Republikanów, numer {0} na listingu.\n", Republican);
				break;
				case NewLeft:
				Console.WriteLine("Nowa lewica nazywa się teraz Partią postępu." );
				goto case Progressive;
				case Progressive:
				Console.WriteLine("Oddałaś/eś głos na partie postępu.\n" );
				break;
				case Libertarian:
				Console.WriteLine("Liberalowie głosują na Republikanów." );
				goto case Republican;
				default:
				Console.WriteLine("Nie oddałaś/eś prawidłowego głosu.\n" );
				break;
			}
			Console.WriteLine("Dziękujemy za oddanie głosu." );
			
		}
	
	}
	
	
	
}



