using System;
using Gridnine.FlightCodingTest.Manager.Base;

namespace Gridnine.FlightCodingTest.Manager.Filters
{
	class FilterOverHoursOnGround : Filter
	{
		private int _hour = 0;
		public FilterOverHoursOnGround(int hour)
		{
			_hour = hour;
		}

		public override bool Filtrate(Flight flight)
		{
			if (flight.Segments.Count < 2) return true;

			for (int i = 0; i < flight.Segments.Count - 1; i++)
				if ((flight.Segments[i + 1].DepartureDate - flight.Segments[i].ArrivalDate).Hours < _hour)
					return true;
			return false;
			
		}
	}
}