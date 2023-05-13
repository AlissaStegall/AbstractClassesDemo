using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		public Motorcycle()
		{
		}

        public bool HasSideCar { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle is in drive");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle is in drive, virtually");
        }
    }
}

