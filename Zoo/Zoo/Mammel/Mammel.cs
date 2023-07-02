using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Mammel
{
    public abstract class Mammel : Animal
    {
        public Mammel(string name, string numberOfLegs, string eat, string bodyCover)
            : base(name, numberOfLegs, eat, bodyCover)
        { }
        public override void reproduction()
        {
            Console.WriteLine($"Mammels Giving Birth");
        }
        public override void FeedKids()
        {
            Console.WriteLine("Mammels Feed their kids milk");
        }

        public override void Behaver()
        {
            Console.WriteLine("Mammals are among the animals with a variety of " +
                "behavior according to their types, as each type shows specific " +
                "behaviors commensurate with its way of life, as most species " +
                "tend to live in interdependent groups throughout their lives");
        }

    }
}
