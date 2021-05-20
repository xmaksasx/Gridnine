using Gridnine.FlightCodingTest.Manager.Base;

namespace Gridnine.FlightCodingTest.Manager.Filters
{
	class FilterDepartsBeforeArrives : Filter
	{
		public override bool Filtrate(Flight flight)
		{
			if (flight.Segments[0].DepartureDate < flight.Segments[0].ArrivalDate)
				return true;
			return false;
		}
	}
}