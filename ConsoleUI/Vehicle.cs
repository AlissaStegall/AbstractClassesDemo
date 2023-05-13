using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		public Vehicle()
		{
		}

		public int Year { get; set; } = 1;
		public string Make { get; set; } = "Default Make";
		public string Model { get; set; } = "Default Model";

		public abstract void DriveAbstract();

		public virtual void DriveVirtual()
		{
			Console.WriteLine("Vehicle is in drive, virtually");
		}
	}
}

