using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interfaces;

namespace Zoo.Birds
{
	public class Ostrich : Bird ,IJungleAnimal
	{

		//implement Bird
		public Ostrich(string name, string numberOfLegs, string eat) 
			: base(name, numberOfLegs, eat)
		{
		}

		//implement Bird
		public override void Behaver()
		{
			Console.WriteLine("Ostrichs are the Biggest Birds type, and they can't fly");
		}

		//implement IJungleAnimal
		public bool LivesWithHuman()
		{
			return false;
		}

		//implement IJungleAnimal
		public bool Safe()
		{
			return true;
		}
	}
}
