using System;
using System.Collections.Generic;
using Gridnine.FlightCodingTest.Manager.Base;

namespace Gridnine.FlightCodingTest.Manager
{
	class FilterManager
	{
		private List<IFilter> _filters = new List<IFilter>();

		public void AddFilter(IFilter filter)
		{
			_filters.Add(filter);
		}

		public void Process(IList<Flight> flights)
		{
			List<Flight> outFlights = new List<Flight>(flights);

			foreach (var filter in _filters)
			{
				outFlights = (List<Flight>) Execute(filter, outFlights);

			}

			foreach (var flight in outFlights)
				Console.WriteLine("Отправление - " + flight.Segments[0].DepartureDate + " : " + "Прибытие - " +
				                  flight.Segments[0].ArrivalDate);
		}

		private IList<Flight> Execute(IFilter filter, IList<Flight> flights)
		{
			return filter.Filtrate(flights);
		}
	}
}