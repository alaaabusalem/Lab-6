using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interfaces;

namespace Zoo.Mammel
{
    public class Lion : Mammel, IJungleAnimal
    {
		//implement Mammel
		public Lion(string name, string numberOfLegs, string eat, string bodyCover)
            : base(name, numberOfLegs, eat, bodyCover)
        { }
		//implement Mammel
        public override void Behaver()
        {
            Console.WriteLine("Lions live in Groups, and each lion can eats 35 kg of meat in one meal, and chews the food with his teeth then swallows it without chewing it.");
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
