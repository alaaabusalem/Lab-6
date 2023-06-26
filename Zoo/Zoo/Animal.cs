using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
	public abstract class Animal
	{
		protected string Name;
		protected string NumberOfLegs;
		protected string Eat;
		protected string BodyCover;

		public Animal(string name, string numberOfLegs, string eat, String bodyCover) { 
		this.Name = name;	
        this.NumberOfLegs = numberOfLegs;
        this.Eat = eat;
        this.BodyCover = bodyCover;	
		}	
		
		public abstract void reproduction();
		public  void PrintInfo()
		{
			Console.WriteLine($"the {Name} Eat {Eat} and cover his body the {BodyCover}");
		}

		
		public abstract void FeedKids();
		public abstract void Behaver();

		public string GetName()
		{
				
			return Name;
		}

	}

	
}
