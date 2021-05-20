using System;
using System.Collections.Generic;
using Gridnine.FlightCodingTest.Manager.Base;

namespace Gridnine.FlightCodingTest.Manager.Filters
{
	class FilterNowTime : Filter
	{
		private DateTime _currentTime;

		public FilterNowTime(DateTime time)
		{
			_currentTime = time;
		}

		public override IList<Flight> Filtrate(IList<Flight> flights)
		{
			List<Flight> outFlights = new List<Flight>();
			foreach (var flight in flights)
				if (flight.Segments[0].DepartureDate > _currentTime)
					outFlights.Add(flight);
			return outFlights;
		}


	
	}
}