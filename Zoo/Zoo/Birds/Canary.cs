using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interfaces;

namespace Zoo.Birds
{
	public class Canary : Bird ,IJungleAnimal, IPet
	{
		//implement Bird
		public Canary(string name, string numberOfLegs, string eat) : base(name, numberOfLegs, eat)
		{
		}

		// implement IPet
		public bool Adoption { get;set; }

		//implement IJungleAnimal
		public bool LivesWithHuman()
		{
			return true;
		}

		//implement IJungleAnimal
		public bool Safe()
		{
			return true;
		}
		// implement IPet
		public bool VaildForAdoption()
		{
		if (Adoption) { return true; }
		return false;	
		}
	}
}
