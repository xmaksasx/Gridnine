using System;
using System.Collections.Generic;
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

		public override IList<Flight> Filtrate(IList<Flight> flights)
		{
			List<Flight> outFlights = new List<Flight>();
			foreach (var flight in flights)
			{
				if (flight.Segments.Count < 2)
				{
					outFlights.Add(flight);
					continue;
				}
				for (int i = 0; i < flight.Segments.Count - 1; i++)
					if ((flight.Segments[i + 1].DepartureDate - flight.Segments[i].ArrivalDate).Hours < _hour)
						outFlights.Add(flight);
			}

			return outFlights;
		}
	}
}