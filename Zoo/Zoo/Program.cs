using Zoo.Birds;
using Zoo.Mammel;
using Zoo.Reptile;

namespace Zoo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Zoo zoo = new Zoo();
			zoo.AddAnimal(new Lion("Zezo Lion", "4", "Meat", "Hair"));
			zoo.AddAnimal(new Eagle("Semo Eagle", "2", "Meat"));
			zoo.AddAnimal(new Snake(" Soso Snake", "No Legs", "Meat"));
			zoo.AddAnimal(new Giraffe("Kady Girrafe", "4", "Plants leaves", "Hair"));
			zoo.AddAnimal(new Ostrich("Meme Ostrich", "2", "Plants"));
		

			string result = "";
			
			while (result !="5") {
				Console.WriteLine("Enter the name of procces:" +
					" \n 1.Show the animals that exist in the zoo " +
			" \n 2.Remove animal" +
			" \n 3.more info about an animal" +
			" \n 4.info about all animal in the zoo" +
			" \n 5.exit");
				result = Console.ReadLine();
				if (result == "1")
				{
					zoo.PrintAllAnimals();

				}
				if(result == "2") {

					Console.WriteLine("Enter animal name you want to remove from the list");
					string Name = Console.ReadLine();
					zoo.RemoveAnimal(Name);	
				}
				if (result == "3")
				{
					Console.WriteLine("Enter animal name you want to now more information about it");
					string Name = Console.ReadLine();
					zoo.PrintAnimalInfo(Name);	
				}
			 
			}
		}
	}
}