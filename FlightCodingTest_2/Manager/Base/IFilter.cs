using System.Collections.Generic;

namespace Gridnine.FlightCodingTest.Manager.Base
{
	internal interface IFilter
	{
		IList<Flight> Filtrate(IList<Flight> flights);
	}
}