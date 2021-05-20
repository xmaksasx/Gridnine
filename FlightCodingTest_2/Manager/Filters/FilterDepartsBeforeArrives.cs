using System.Collections.Generic;
using Gridnine.FlightCodingTest.Manager.Base;

namespace Gridnine.FlightCodingTest.Manager.Filters
{
	class FilterDepartsBeforeArrives : Filter
	{
		public override IList<Flight> Filtrate(IList<Flight> flights)
		{
			List<Flight> outFlights = new List<Flight>();

			foreach (var flight in flights)
				if (flight.Segments[0].DepartureDate < flight.Segments[0].ArrivalDate)
					outFlights.Add(flight);
			return outFlights;
		}

	}
}