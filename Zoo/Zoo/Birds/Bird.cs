using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Birds
{
	public class Bird : Animal
	{
		public Bird(string name, string numberOfLegs, string eat) 
			: base(name, numberOfLegs, eat, "feather")
		
		{
		}

		public override void Behaver()
		{
			Console.WriteLine("They're always moving, flying, hopping, swimming, " +
				"singing, or interacting. They're often climbing, probing, picking" +
				", eating, displaying, or doing something that draws our attention" +
				". Sometimes a bird's behavior is easily understood");
		}

		public override void FeedKids()
		{
			Console.WriteLine("in Birds, The mother search for food and gives it to her children");
		}

		public override void reproduction()
		{
			Console.WriteLine("Birds lay eggs. ");
		}
	}
}
