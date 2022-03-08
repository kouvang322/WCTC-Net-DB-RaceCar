using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
	public class Tom : Driver
	{
		public Tom(RaceCar car) : base (car)
		{
			Name = "Tom";
			SkillLevel = 15;
		}

		public override void Drive()
        {
			Car.Accelerate(SkillLevel);
		}
	}
}
