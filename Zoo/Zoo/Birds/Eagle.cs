using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interfaces;

namespace Zoo.Birds
{
	public class Eagle : Bird ,IJungleAnimal
	{
		//implement Bird
		public Eagle(string name, string numberOfLegs, string eat) 
			: base(name, numberOfLegs, eat)
		{
		}

		//implement Bird
		public override void Behaver()
		{
			Console.WriteLine("Eagles are some of the largest birds. They are at the top of the food chain, with some species feeding on big prey like monkeys and sloths. Eagles have amazing eyesight and can detect prey up to two miles away, and they are carnivorous.");
		}

		//implement IJungleAnimal
		public bool LivesWithHuman()
		{
			return false;
		}

		//implement IJungleAnimal
		public bool Safe()
		{
			return false;
		}
	}
}
