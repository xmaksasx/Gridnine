using System;
using Gridnine.FlightCodingTest.Manager.Base;

namespace Gridnine.FlightCodingTest.Manager.Filters
{
	public class FilterNowTime : Filter
	{
		private DateTime _currentTime;

		public FilterNowTime(DateTime time)
		{
			_currentTime = time;
		}

		public override bool Filtrate(Flight flight)
		{
			return flight.Segments[0].DepartureDate > _currentTime;
		}
	}
}
