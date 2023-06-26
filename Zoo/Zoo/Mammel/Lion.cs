using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Mammel
{
    internal class Lion : Mammel
    {
        public Lion(string name, string numberOfLegs, string eat, string bodyCover)
            : base(name, numberOfLegs, eat, bodyCover)
        { }
        public override void Behaver()
        {
            Console.WriteLine("Lions live in Groups, and each lion can eats 35 kg " +
                "of meat in one meal, and chews the food with his teeth then " +
                "swallows it without chewing it.");
        }

    }
}
