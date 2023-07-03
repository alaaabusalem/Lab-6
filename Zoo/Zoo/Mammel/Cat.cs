using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interfaces;

namespace Zoo.Mammel
{
	public class Cat : Mammel , IPet
	{

		// implement Mammel
		public Cat(string name, string numberOfLegs, string eat, string bodyCover) : base(name, numberOfLegs, eat, bodyCover)
		{
		}

		//implement IPet
		public bool Adoption { get; set; }

		//implement IPet
		public bool VaildForAdoption()
		{
			if (Adoption) {
				return true;
			}
			else { return false; }
		}
	}
}
