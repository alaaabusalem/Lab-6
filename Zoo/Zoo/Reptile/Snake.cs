using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Reptile
{
    public class Snake : Reptile
    {
        public Snake(string name, string numberOfLegs, string eat)
            : base(name, numberOfLegs, eat)
        { }


		public override void Behaver()
		{
	
			Console.WriteLine("Snakes rely on venom to kill prey and aid in digestion, as well as a means of defense against attack.");
		}
	}
}
