using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Mammel
{
    internal class Giraffe : Mammel
    {
        public Giraffe(string name, string numberOfLegs, string eat, string bodyCover)
            : base(name, numberOfLegs, eat, bodyCover)
        { }
        public override void Behaver()
        {
            Console.WriteLine("The giraffe is characterized by its activity day " +
                "and night, as it spends its day actively in the early and late " +
                "hours, especially in warm regions, and during the hours of " +
                "activity it may practice digestion and movement, while at night " +
                "it spends its time resting, eating, and sleeping.");
        }
    }
}
