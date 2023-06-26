using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Birds
{
	public class Ostrich : Bird
	{
		public Ostrich(string name, string numberOfLegs, string eat) 
			: base(name, numberOfLegs, eat)
		{
		}
		public override void Behaver()
		{
			Console.WriteLine("Ostrichs are the Biggest Birds type, and they can't fly");
		}

	}
}
