using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Reptile
{
    public class Reptile : Animal

    {
        public Reptile(string name, string numberOfLegs, string eat)
            : base(name, numberOfLegs, eat, "scales")
        { }

        public override void FeedKids()
        {
            Console.WriteLine("in Reptile, The mother search for food and gives it to her children");
        }

        public override void reproduction()
        {
            Console.WriteLine("Retile lays eggs");
        }

        public override void Behaver()
        {
            Console.WriteLine("Reptiles naturally use behaviour to select and " +
                "occupy niche temperatures and attain precise thermal conditions. " +
                "Inability to thermoregulate within precise, self-perceived " +
                "(by the animal) needs and even with regard to a single event may " +
                "result in the exacerbation of acute stress as well as chronic " +
                "debilitation.");
        }

    }
}
