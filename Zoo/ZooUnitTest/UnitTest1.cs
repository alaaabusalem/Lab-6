using Zoo.Mammel;
using Zoo.Birds;
using Zoo.Reptile;

namespace ZooUnitTest
{
	public class UnitTest1

	{
		// Lion
		// implement from base class (animal)
		[Fact]
		public void TestConstructor()
		{
			Lion lion = new Lion("Lolo", "4", "meat", "hair");
			string getName= lion.GetName();
			Assert.Equal("Lolo",getName);
		}

		//inherite from Mammel class

		[Fact]
		public void TestReproduction()
		{
			Lion lion = new Lion("Lolo", "4", "meat", "hair");
			var writer = new StringWriter();
			Console.SetOut(writer);
			lion.reproduction();
			var capturedOutput = writer.ToString().Trim();
			Assert.Equal("Mammels Giving Birth", capturedOutput);
		}


		// override Mammel method Behaveor
		[Fact]
		public void TestBehaver()
		{
			Lion lion = new Lion("Lolo", "4", "meat", "hair");
			var writer = new StringWriter();
			Console.SetOut(writer);
			lion.Behaver();
			var capturedOutput = writer.ToString().Trim();
			Assert.Equal("Lions live in Groups, and each lion can eats 35 kg of meat in one meal, and chews the food with his teeth then swallows it without chewing it.", capturedOutput);
		}


		//Giraffe

		//inherite from Mammel class

		[Fact]
		public void TestReproductionGiraffe()
		{
			Giraffe giraffe = new Giraffe("Soso", "4", "Plant", "hair");
			var writer = new StringWriter();
			Console.SetOut(writer);
			giraffe.reproduction();
			var capturedOutput = writer.ToString().Trim();
			Assert.Equal("Mammels Giving Birth", capturedOutput);
		}

		// override Mammel method Behaveor
		[Fact]
		public void TestBehaverGiraffe()
		{
			Giraffe giraffe = new Giraffe("Lolo", "4", "meat", "hair");
			var writer = new StringWriter();
			Console.SetOut(writer);
			giraffe.Behaver();
			var capturedOutput = writer.ToString().Trim();
			Assert.Equal("The giraffe is characterized by its activity day and night, as it spends its day actively in the early and late hours, especially in warm regions, and during the hours of activity it may practice digestion and movement, while at night it spends its time resting, eating, and sleeping.", capturedOutput);
		}
		// Eagle

		[Fact]
		public void TestReproductionEagle()
		{
			Eagle eagle = new Eagle("Soso", "4", "meat");
			var writer = new StringWriter();
			Console.SetOut(writer);
			eagle.reproduction();
			var capturedOutput = writer.ToString().Trim();
			Assert.Equal("Birds lay eggs.", capturedOutput);
		}

		// override Bird method Behaveor
		[Fact]
		public void TestBehaverEagle()
		{
			Eagle eagle = new Eagle("Lolo","4","meat");
			var writer = new StringWriter();
			Console.SetOut(writer);
			eagle.Behaver();
			var capturedOutput = writer.ToString().Trim();
			Assert.Equal("Eagles are some of the largest birds. They are at the top of the food chain, with some species feeding on big prey like monkeys and sloths. Eagles have amazing eyesight and can detect prey up to two miles away, and they are carnivorous.", capturedOutput);
		}

		// Ostrich

		[Fact]
		public void TestReproductionOstrich()
		{
			Ostrich ostrich = new Ostrich("Soso", "2", "Plant");
			var writer = new StringWriter();
			Console.SetOut(writer);
			ostrich.reproduction();
			var capturedOutput = writer.ToString().Trim();
			Assert.Equal("Birds lay eggs.", capturedOutput);
		}

		// override Bird method Behaveor
		[Fact]
		public void TestBehaverOstrich()
		{
			Ostrich ostrich = new Ostrich("Lolo", "2", "Plant");
			var writer = new StringWriter();
			Console.SetOut(writer);
			ostrich.Behaver();
			var capturedOutput = writer.ToString().Trim();
			Assert.Equal("Ostrichs are the Biggest Birds type, and they can't fly", capturedOutput);
		}

		// Snake

		[Fact]
		public void TestReproductionSnake()
		{
			Snake snake = new Snake("Soso", "No legs", "meat");
			var writer = new StringWriter();
			Console.SetOut(writer);
			snake.reproduction();
			var capturedOutput = writer.ToString().Trim();
			Assert.Equal("Retile lays eggs", capturedOutput);
		}

		// override Bird method Behaveor
		[Fact]
		public void TestBehaverSnake()
		{
			Snake snake = new Snake("Lolo", " No legs", "meat");
			var writer = new StringWriter();
			Console.SetOut(writer);
			snake.Behaver();
			var capturedOutput = writer.ToString().Trim();
			Assert.Equal("Snakes rely on venom to kill prey and aid in digestion, as well as a means of defense against attack.", capturedOutput);
		}
	}
}