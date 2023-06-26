using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
	public class Zoo
	{

		List<Animal> Animals;
		public Zoo() {
			Animals = new List<Animal>();

		}	

		public void AddAnimal(Animal animal) {

			Animals.Add(animal);
		}

		public void RemoveAnimal(string name) {

			if (Animals.Count > 0)
			{

				for (int i = 0; i < Animals.Count; i++)
				{
					if (Animals[i].GetName().ToLower().Equals(name.ToLower()))
					{
						Animals.Remove(Animals[i]);
					}
				}
			} 
		}
		public void PrintAnimalInfo(string name)
		{
			if (Animals.Count > 0)
			{

				for (int i = 0; i < Animals.Count; i++)
				{
					if (Animals[i].GetName().ToLower().Equals(name.ToLower()))
					{
						Animals[i].PrintInfo();
						Animals[i].Behaver();
						Animals[i].reproduction();
						Animals[i].FeedKids();
					}
					
				}
			}

			
		}

       public void PrintAllAnimals()
		{
			if(Animals.Count > 0) { 
			foreach(Animal animal in Animals)
			{
					Console.WriteLine(animal.GetName()) ;
					//animal.PrintInfo();
			}
			}
		}

	}

	
}
