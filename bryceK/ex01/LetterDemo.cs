using System;
using static System.Console;
using System.Globalization;
namespace Chapter10Exercises
{
	class LetterDemo
	{
		static void Main()
		{
			WriteLine("test");
		}
	}
	public class Letter {
		public string Name { get; set; }
		public string Date {get; set; }

		public override string ToString() {
			return (GetType() + ": " + Name + ", " + Date);
		}
	}
	public class CertifiedLetter : Letter {
		public string TrackingNumber { get; set; }
	}
}
