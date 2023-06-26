using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Birds
{
	internal class Eagle : Bird
	{
		public Eagle(string name, string numberOfLegs, string eat) 
			: base(name, numberOfLegs, eat)
		{
		}
		public override void Behaver()
		{
			Console.WriteLine("Eagles are some of the largest birds. They are at " +
				"the top of the food chain, with some species feeding on big " +
				"prey like monkeys and sloths. Eagles have amazing eyesight " +
				"and can detect prey up to two miles away, and they are carnivorous. ");
		}
	}
}
