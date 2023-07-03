using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Interfaces
{
	// Interface members
	interface IPet
	{
		bool Adoption { get; set; }
		bool VaildForAdoption();

	}
}
