using System.Collections.Generic;

namespace Gridnine.FlightCodingTest.Manager.Base
{
	abstract class Filter: IFilter
	{
		public virtual IList<Flight> Filtrate(IList<Flight> flights)
		{
			throw new System.NotImplementedException();
		}

		
	}
}
