using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
	public class MitsubishiLancer: RaceCar
	{
		public MitsubishiLancer()
		{
			Name = "Mitsubishi";
			TopSpeed = 120;
		}

		public override void StartEngine()
		{
			Console.WriteLine($"The {Name} starts with a load roar.");
		}

		public override void Brake()
		{
			Console.WriteLine($"The {Name} quickly slows down to a halt!");
			base.Brake();
		}

		public override void StopEngine()
		{
			Console.WriteLine($"The {Name} engine stops running with a silent sizzle.");

		}
	}
}
